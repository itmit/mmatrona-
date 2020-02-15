using Matrona.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrona.ViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonViewCell : ViewCell
    {
        public PersonViewCell()
        {
            InitializeComponent();
            BindingContext = new PersonsViewModel();
        }
    }
}