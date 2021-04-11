using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XAMLStartApp.ViewModel;

namespace XAMLStartApp.View
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage()
		{
			InitializeComponent();
			this.BindingContext = new SecondPageViewModel();
		}

		/// <summary>
		/// OnAppearing
		/// </summary>
		protected override void OnAppearing()
		{
			base.OnAppearing();

			// Set BindingContext for password entry behavior
			foreach (var behavior in this.NameEntry.Behaviors)
			{
				behavior.BindingContext = this.BindingContext;
			}
		}
	}
}
