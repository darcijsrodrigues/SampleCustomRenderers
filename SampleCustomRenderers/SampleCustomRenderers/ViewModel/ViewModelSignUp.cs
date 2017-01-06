using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;

namespace SampleCustomRenderers.ViewModels
{
	public class ViewModelSignUp:BaseViewModel
	{

		private string _firtName;
		public string FirstName{
			get{  return _firtName; }
			set{
				_firtName = value;
				NotifyPropertyChange("FirstName");
			}
		}

		private string _lastname;
		public string LastName{
			get{  return _lastname; }
			set{
				_lastname = value;
				NotifyPropertyChange("LastName");
			}
		}

		private string _email;
		public string Email{
			get{  return _email; }
			set{
				_email = value;
				NotifyPropertyChange("Email");
			}
		}

		private string _password;
		public string Password{
			get{  return _password; }
			set{
				_password = value;
				NotifyPropertyChange("Password");
			}
		}

		private Dictionary<int, string> _genders;
		public Dictionary<int, string> Genders{
			get{  return _genders; }
			set{
				_genders = value;
				NotifyPropertyChange("Genders");
			}
		}

		private int _selectedIndex;
		public int SelectedIndex{
			get{  return _selectedIndex; }
			set{
				_selectedIndex = value;
				NotifyPropertyChange("SelectedIndex");
			}
		}

		public ICommand cmdSignUp { get; set; }

		public ICommand cmdFooterLogin { get; set; }

		public ICommand cmdFooterSignUp { get; set; } // verificar o uso desse command 

		public ViewModelSignUp ()
		{
			_genders = new Dictionary<int, string> ();
			LoadGenders ();

			this.cmdFooterLogin = new Command (() => {
				MessagingCenter.Send<String>("","Login");
			});
		}

		private void LoadGenders(){
			Genders.Add(0, "Male");
			Genders.Add(1, "Female");
			Genders.Add(2, "Female");
			Genders.Add(3, "Female");
			Genders.Add(4, "Female");
		}
	}
}

