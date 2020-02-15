using Matrona.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrona.ViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewCell : ViewCell
    {
        public TableViewCell()
        {
            InitializeComponent();
            BindingContext = new TableViewModel();
        }
    }
}