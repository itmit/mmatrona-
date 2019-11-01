using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Matrona.ViewModel;

namespace Matrona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class News : ContentPage
    {
        public News()
        {
            InitializeComponent();
            try { BindingContext = new ListViewModel(); }
            catch { }
        }
    }
}
