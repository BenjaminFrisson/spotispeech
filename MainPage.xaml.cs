using Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpotiSpeech
{
    public partial class MainPage : ContentPage
    {
        Ice.Communicator communicator;
        Ice.ObjectPrx obj;
        Demo.PrinterPrx printer;
        public MainPage()
        {
            InitializeComponent();
            try
            {
                //Initialisation de ICE (communicator & adapter)
                communicator = Ice.Util.initialize();
                obj = communicator.stringToProxy("SimplePrinter:default -h localhost -p 10000");
                printer = PrinterPrxHelper.checkedCast(obj);
                if (printer == null)
                {
                    throw new ApplicationException("Invalid proxy");
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if((sender as Button).Text.Equals("Enregistrer")){
                (sender as Button).Text = $"Enregistrement";
                (sender as Button).BackgroundColor = Color.Gray;
            }
            else
            {
                (sender as Button).Text = $"Enregistrer";
                (sender as Button).BackgroundColor = Color.Black;
            }
            
        }

        private async void OnArrowClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Ici");
            //printer.ChangeTrack("Piton - Haikyuu");
            await Navigation.PushAsync(new PlayerPage());
            
        }
    }
}
