using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrona.View;
using Xamarin.Forms;

namespace Matrona
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new News())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = true;
        }

        private void News_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new News())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black,
            };  
            IsPresented = false;
        }

        private void Help_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Help())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }

        private void Table_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Table())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }

        private void Temple_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TheTemple())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }

        private void Contact_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Contact())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }

        private void Person_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Person())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }

        private void Matrona_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MatronaM())
            {
                BarBackgroundColor = Color.FromHex("#fde566"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }
    }
}
