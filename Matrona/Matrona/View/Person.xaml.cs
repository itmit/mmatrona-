using Matrona.Model;
using Matrona.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrona.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Person : ContentPage
    {
        public Person()
        {
            InitializeComponent();
            BindingContext = new PersonsViewModel();
        }
    }
}