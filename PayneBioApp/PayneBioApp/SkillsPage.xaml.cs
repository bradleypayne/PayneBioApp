using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PayneBioApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<String> Skills { get; set; }
		public SkillsPage ()
		{
			InitializeComponent ();
            this.Skills = new ObservableCollection<string>();
            this.Skills.Add("C+");
            this.Skills.Add("Python");
            this.Skills.Add("VBA");
            this.Skills.Add("Xamarin");
            this.Skills.Add("C#");
            this.Skills.Add("BS in Mathematics");
            this.Skills.Add("");
            SkillsListView.ItemsSource = this.Skills;


        }
	}
    
}