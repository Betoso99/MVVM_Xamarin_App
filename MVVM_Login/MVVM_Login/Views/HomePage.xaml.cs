using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Login.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Login.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : TabbedPage
	{
		public HomePage()
		{
			InitializeComponent();
			BindingContext = new MenuOptionViewModel();
		}
	}
}