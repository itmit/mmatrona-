using Matrona.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Matrona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Table : ContentPage
    {
        public List<ListNews> Lists { get; }
        public ListNews[] Data { get; }
        public string[] Stroka { get; set; }
        public Table()
       {
           
            InitializeComponent();
            try
            {
                var webClient = new WebClient();
                var respons = webClient.DownloadString("https://mmatrona.ru/raspisanie/");
                MatchCollection match = Regex.Matches(respons, "srcset=\"(.+?) 1131w");
                Data = new ListNews[match.Count];
                Stroka = new string[match.Count];
                for (var i = 0; i < match.Count; i++)
                {
                    Stroka[i] = match[i].Value.Replace("srcset=\"", " 1131w").Replace(" 1131w", "");
                    Data[i] = new ListNews { SorceImage = Stroka[i] };
                }
               
                Lists = new List<ListNews>(match.Count);
                Lists.AddRange(Data);
                BindingContext = this;
            }
            catch
            { 
            }
        }
    }  
}