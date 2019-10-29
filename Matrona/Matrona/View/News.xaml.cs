using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrona.Model;
using System.Text.RegularExpressions;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrona
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class News : ContentPage
    {
        public List<ListNews> Lists { get; set; }
        public ListNews[] Data { get; set; }
        public string[] Title { get; set; }
        public string[] Span { get; set; }
        public News()
        {
            InitializeComponent();
            try
            {
                var webClient = new WebClient();
                var Response = webClient.DownloadString("https://mmatrona.ru/feed/");
                MatchCollection matchesSpan = Regex.Matches(Response, @"<span>(?'text'.*?)</span>");
                MatchCollection matchesTitle = Regex.Matches(Response, @"\t\t<title>(?'text'.*?)</title>");

                Data = new ListNews[matchesSpan.Count];
                Title = new string[matchesSpan.Count];
                Span = new string[matchesSpan.Count];

                for (int i = 0; i < matchesSpan.Count; i++)
                {
                    Title[i] = Regex.Replace(matchesTitle[i].Groups["text"].Value, @"&#[8][2][2][0-1];", @"""").Replace("&#8211;","—");
                    Span[i] = Regex.Replace(matchesSpan[i].Groups["text"].Value, @"&#[8][2][2][0-1];", @"""").Replace("&#8211;", "—");
                    Data[i] = new ListNews { Title = Title[i], Span = Span[i] };
                }

                Lists = new List<ListNews>(matchesSpan.Count);
                Lists.AddRange(Data);
                BindingContext = this;
            }
            catch
            {

            }
        }
    }
}
