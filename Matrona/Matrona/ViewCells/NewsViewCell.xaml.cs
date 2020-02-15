using Matrona.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrona.ViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsViewCell : ViewCell
    {
        public NewsViewCell()
        {
            InitializeComponent();
            BindingContext = new ListViewModel();
        }
    }
}