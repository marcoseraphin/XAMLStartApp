using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAMLStartApp.View;

namespace XAMLStartApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		void Button_Clicked(System.Object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SecondPage());
		}
	}
}
