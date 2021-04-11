using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace XAMLStartApp.ViewModel
{
	public class SecondPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _ChangeButtonEnabled;
        public bool ChangeButtonEnabled
        {
            get
            {
                return _ChangeButtonEnabled;
            }
            set
            {
                _ChangeButtonEnabled = value;
                OnPropertyChanged("ChangeButtonEnabled");
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _NewName;
        public string NewName
        {
            get
            {
                return _NewName;
            }
            set
            {
                _NewName = value;
                OnPropertyChanged("NewName");
            }
        }

		/// <summary>
		/// OnPropertyChanged
		/// </summary>
		/// <param name="propertyName"></param>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		/// <summary>
		/// ChangeNameCommand
		/// </summary>
		public Command ChangeNameCommand
		{
			get
			{
                return new Command(() =>
                {
                    try
                    {
                        this.Name = this.NewName;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error in ChangeNameCommand: " + ex.Message);
                    }
                }, () => this.ChangeButtonEnabled 
                );
			}
		}

		/// <summary>
		/// ctor
		/// </summary>
		public SecondPageViewModel()
		{ 
            this.NewName = String.Empty;
            this.ChangeButtonEnabled = false;
            this.Name = "Marco Seraphin";
		}
	}
}
