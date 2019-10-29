using Matrona.Model;
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
    public partial class MatronaM : ContentPage
    {
        public MatronaM()
        {
            InitializeComponent();
            Match match = Regex.Match(Text.Str(), @"<2>(?'matrona'.*?)<2><3>(?'warning'.*?)<3>");
            Matrona.Text = match.Groups["matrona"].Value + "\n\n";
            Warning.Text = match.Groups["warning"].Value;
        }
    }
}