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



	}

}

