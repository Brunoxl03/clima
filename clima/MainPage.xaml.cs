namespace clima;

public partial class MainPage : ContentPage

{

	public MainPage()
	{
		InitializeComponent();
	}

	results results = new results();
	void TestaLayout ()
	{
		results.temp =23;

	}
	void preenchertela()
	{
		LabelTemp.Text = resposta.results.temp.ToString();

		LabelDescription.Text = resposta.results.temp.ToString();

		LabelCity.Text = resposta.results.city;

		LabelHumidity.Text = resposta.results.temp.ToString();

		LabelRain.Text= resposta.results.rain;

		LabelSunrise.Text= resposta.results.sunrise;

		Labelsunset.Text= resposta.results.sunset;

		labelwind_speedy= resposta.results.wind_speedy;

		Labelwind_direction= resposta.results.wind_direction;

		Labelmoon_phase= resposta.results.moon_phase;

		Labelcurrently= resposta.results.currently;

		Labelimg_id= resposta.results.img_id;
		
		Labelcondition_code= resposta.results.condition_code;


	}

}

