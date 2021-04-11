using System;
using Xamarin.Forms;
using XAMLStartApp.ViewModel;

namespace XAMLStartApp.Behavior
{
	public class NameCheckBehavior : Behavior<Entry>
	{
		private SecondPageViewModel secondPageViewModel = null;

		protected override void OnAttachedTo(Entry entry)
		{
			entry.TextChanged += OnEntryTextChanged;
			base.OnAttachedTo(entry);
		}

		protected override void OnDetachingFrom(Entry entry)
		{
			entry.TextChanged -= OnEntryTextChanged;
			base.OnDetachingFrom(entry);
		}

		void OnEntryTextChanged(object sender, TextChangedEventArgs args)
		{
			bool isValid = args.NewTextValue.Length >= 5;
			((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;

			this.secondPageViewModel = BindingContext as SecondPageViewModel;
			if (this.secondPageViewModel != null)
			{
				this.secondPageViewModel.ChangeButtonEnabled = isValid;
			}
		}

		public NameCheckBehavior()
		{
		}
	}
}
