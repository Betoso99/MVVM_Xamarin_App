using MVVM_Login.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Login
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new LogSingPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
