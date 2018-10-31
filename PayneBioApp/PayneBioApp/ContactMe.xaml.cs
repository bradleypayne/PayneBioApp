using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PayneBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMe : ContentPage
	{
		public ContactMe ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
                DisplayAlert("Error", "Please enter name", "Ok");
            if (string.IsNullOrEmpty(email.Text))
                DisplayAlert("Error", "Please enter e-mail", "Ok");
            if (string.IsNullOrEmpty(message.Text))
                DisplayAlert("Error", "Please enter message", "Ok");
            else
            {
                DisplayAlert("Thank You!", "Your message has been sent!", "Ok");
            }

            message.Text = null;
            name.Text = null;
            email.Text = null;

                return;
        }
    }
}