using GalaSoft.MvvmLight.Command;
using MVVM_Login.Model;
using MVVM_Login.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Login.ViewModels
{
	public class LogSingViewModel : BaseViewModel
	{
		public User User { get; set; }

		public ICommand LogInCommand {get;set;}
		public ICommand SingUpCommand { get; set; }

		public LogSingViewModel()
		{
			User = new User();
			LogInCommand = new Command(async () =>
			{
				if (string.IsNullOrEmpty(User.Name) | string.IsNullOrEmpty(User.Pass))
				{
					await App.Current.MainPage.DisplayAlert("Error", "Something is missing", "Ok");
				}
				else
				{
					await App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
					await App.Current.MainPage.DisplayAlert("Welcome", $"Welcome again {User.Name}", "Ok");
				}
			});

			SingUpCommand = new Command(async () =>
			{
				if (string.IsNullOrEmpty(User.Name) |
				string.IsNullOrEmpty(User.Email) |
				string.IsNullOrEmpty(User.Pass1) |
				string.IsNullOrEmpty(User.Pass2))
				{
					await App.Current.MainPage.DisplayAlert("Error", "Something is missing", "Ok");
				}
				else if (User.Pass1!= User.Pass2)
				{
					await App.Current.MainPage.DisplayAlert("Error", "The Passwords are not the same", "Ok");
				}
				else
				{
					await App.Current.MainPage.Navigation.PushModalAsync(new HomePage());
					await App.Current.MainPage.DisplayAlert("Welcome", $"Welcome again {User.Name}", "Ok");
				}
			});
		}
	}
}
