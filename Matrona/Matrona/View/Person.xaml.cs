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
    public partial class Person : ContentPage
    {
        public List<ListNews> Lists { get; }
        public ListNews[] Data { get; }
        public string[] Title { get; }
        public string[] Span { get; }
        public string[] Image { get; }
        public Person()
        {
            InitializeComponent();

            MatchCollection matchesSpan = Regex.Matches(Text.Str(), @"<span>(?'text'.*?)</span>");
            MatchCollection matchesTitle = Regex.Matches(Text.Str(), @"<title>(?'text'.*?)</title>");

            Image = new string[] { "one.png", "two.png", "three.png", "four.png", "five.png" };
            Data = new ListNews[matchesSpan.Count];
            Title = new string[matchesSpan.Count];
            Span = new string[matchesSpan.Count];

            for (var i = 0; i < matchesSpan.Count; i++)
            {
                Title[i] = matchesTitle[i].Groups["text"].Value;
                Span[i] = matchesSpan[i].Groups["text"].Value;
                Data[i] = new ListNews { Title = Title[i], Span = Span[i], SorceImage = Image[i] };
            }

            Lists = new List<ListNews>(matchesSpan.Count);
            Lists.AddRange(Data);
            BindingContext = this;
        }
    }
}