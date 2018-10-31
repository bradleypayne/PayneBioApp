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
	public partial class altmainpage : ContentPage
	{
		public altmainpage ()
		{
			InitializeComponent ();
		}

        private void aboutmebutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void skillsbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactMebutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMe());
        }

        private void Photosbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PhotosPage());
        }
    }
}