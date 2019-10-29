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
    public partial class TheTemple : ContentPage
    {
        public TheTemple()
        {
            InitializeComponent();
            Match match = Regex.Match(Text.Str(), @"<1>(?'temple'.*?)<1>");
            TempleText.Text = match.Groups["temple"].Value;
        }
    }
}