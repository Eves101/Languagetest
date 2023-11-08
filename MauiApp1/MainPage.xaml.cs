using Lang = MauiApp1.Resources.Translations.Resource;
namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			

			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);

			if(Application.Current is not null && Application.Current.MainPage is not null)
			{
				await Application.Current.MainPage.DisplayAlert("Alert", "You have (not) been alerted", Lang.MsgOk );

			}
		}
	}

}
