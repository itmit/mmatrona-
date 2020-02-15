using Matrona.Model;
using Matrona.Service;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Matrona.ViewModel
{
    class ListViewModel
    {
        public List<ListNews> Lists { get; set; }
        public ListNews[] Data { get; set; }
        public string[] Title { get; set; }
        public string[] Span { get; set; }
        public ListViewModel()
        {
            var parserService = new ParserService();
            var count = parserService.Span.Count;

            Data = new ListNews[count];
            Title = new string[count];
            Span = new string[count];

            for (int i = 0; i < count; i++)
            {
                Title[i] = Regex.Replace(parserService.Title[i].Groups["text"].Value, @"&#[8][2][2][0-1];", @"""").Replace("&#8211;", "—");
                Span[i] = Regex.Replace(parserService.Span[i].Groups["text"].Value, @"&#[8][2][2][0-1];", @"""").Replace("&#8211;", "—");
                Data[i] = new ListNews { Title = Title[i], Span = Span[i] };
            }

            Lists = new List<ListNews>(count);
            Lists.AddRange(Data);
        }
    }
}
