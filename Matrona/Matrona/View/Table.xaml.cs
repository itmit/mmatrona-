
using Matrona.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Table : ContentPage
    {
        public Table()
       {
            InitializeComponent();
            try { BindingContext = new TableViewModel(); }
            catch { }
        }
    }  
}