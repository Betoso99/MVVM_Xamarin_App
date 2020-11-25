using MVVM_Login.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Login.ViewModels
{
	public class MenuOptionViewModel
	{
		public MenuOptions BarAndHotelsOption { get; set; } = new MenuOptions();
		public MenuOptions CoffeAndTe { get; set; } = new MenuOptions();
		public MenuOptions Dessert { get; set; } = new MenuOptions();
		public MenuOptions FastFood { get; set; } = new MenuOptions();
		public MenuOptions Pizza { get; set; } = new MenuOptions();
		public MenuOptions Restaurant { get; set; } = new MenuOptions();

		public MenuOptionViewModel()
		{
			BarAndHotelsOption.Title = "Bar And Hotels";
			BarAndHotelsOption.Amount = "35 Places";
			BarAndHotelsOption.Image = "Bars.png";

			CoffeAndTe.Title = "Coffe And Te";
			CoffeAndTe.Amount = "15 Places";
			CoffeAndTe.Image = "CoffeAndTe.png";

			Dessert.Title = "Dessert";
			Dessert.Amount = "22 Places";
			Dessert.Image = "Dessert.png";

			FastFood.Title = "Fast Food";
			FastFood.Amount = "56 Places";
			FastFood.Image = "FastFood.png";

			Pizza.Title = "Pizza";
			Pizza.Amount = "23 Places";
			Pizza.Image = "Pizza.png";

			Restaurant.Title = "Restaurant";
			Restaurant.Amount = "18 Places";
			Restaurant.Image = "Restaurant.png";
		}
	}
}
