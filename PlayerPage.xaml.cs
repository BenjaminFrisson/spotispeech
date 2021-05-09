using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo;

namespace SpotiSpeech
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerPage : ContentPage
    { 
        public PlayerPage()
        {
            InitializeComponent(); 
        }

        private void OnPlayClicked(object sender, EventArgs e)
        {
        }
        private void OnPauseClicked(object sender, EventArgs e)
        {
        }

    }
}