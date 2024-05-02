using System.Text.Json;
 
namespace clima;

public partial class MainPage : ContentPage

{
	Resposta resposta;
	const string Url="https://api.hgbrasil.com/weather?woeid=455927&key=7ab0717b";

	public MainPage()
	{
		InitializeComponent();
		AtualizaTempo();
	}
	async void AtualizaTempo()
  {
	try
	{
		var httpClient = new HttpClient();
		var  response = await httpClient.GetAsync(Url);
		if (response.IsSuccessStatusCode)
		{
			var content = await response.Content.ReadAsStringAsync();
			resposta = JsonSerializer.Deserialize<Resposta>(content);
		}
		preenchertela();

	}
	catch (Exception e)
	{
		System.Diagnostics.Debug.WriteLine(e);
	}

  }
	
	void preenchertela()
	{
		LabelTemp.Text = resposta.results.temp.ToString();

		LabelDescription.Text = resposta.results.claudiness.ToString();

		LabelCity.Text = resposta.results.city;

		LabelHumidity.Text = resposta.results.humidity.ToString();

		LabelRain.Text= resposta.results.rain.ToString();

		LabelSunrise.Text= resposta.results.sunrise;

		Labelsunset.Text= resposta.results.sunset;

		labelwind_speedy.Text= resposta.results.wind_speedy.ToString();

		Labelwind_direction.Text= resposta.results.wind_direction.ToString();

		Labelmoon_phase.Text= resposta.results.moon_phase;

		Labelcurrently.Text= resposta.results.currently;
		
		Labelcondition_code.Text= resposta.results.condition_code;

		if(resposta.results.moon_phase=="full")
		Labelmoon_phase.Text ="cheia";
		else if(resposta.results.moon_phase=="new")
		Labelmoon_phase.Text = "nova";
		else if(resposta.results.moon_phase=="waxing_crescent")
		Labelmoon_phase.Text = "lua crescente";
		else if(resposta.results.moon_phase=="waxing_gibbous")
		Labelmoon_phase.Text = "gibosa crescente";
		else if(resposta.results.moon_phase=="waning_crescent")
		Labelmoon_phase.Text = "lua minguante";
		else if(resposta.results.moon_phase=="last_quarter")
		Labelmoon_phase.Text = "quarto minguante";
		else if(resposta.results.moon_phase=="last_quarter")
		Labelmoon_phase.Text = "quarta crescente";
		else if(resposta.results.moon_phase=="waning_gibbous")
		Labelmoon_phase.Text = "gibosa minguante";
		

		if(resposta.results.currently=="dia")
		{
			if(resposta.results.rain<=10)
			imgBackground.Source="imgdia.webp";
			if(resposta.results.claudiness>=10)
			imgBackground.Source="imgnublado.webp";
			else
			imgBackground.Source="imgnoite.jpg";
		}





	}

}

