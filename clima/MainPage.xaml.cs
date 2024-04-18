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
		LabelTemp.Text= results.temp.ToString();
		LabelCity.Text= results.city;
	}

}

