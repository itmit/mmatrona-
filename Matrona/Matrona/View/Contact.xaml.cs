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
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
            Match match = Regex.Match(Text.Str(), @"Адрес: (?'contact'.*?)Проезд: (?'contact1'.*?)Храм открыт: (?'contact2'.*?)Телефон (?'contact3'.*?)<4>");

            ContactC.Text = "Адрес:\n\n" + match.Groups["contact"].Value + "\n\n" +
                          "Проезд:\n\n" + match.Groups["contact1"] + "\n\n" +
                          "Храм открыт:\n\n" + match.Groups["contact2"].Value + "\n\n" +
                          "Телефон " + match.Groups["contact3"].Value;
        }
    }
}