using Matrona.Model;
using Matrona.Service;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Matrona.ViewModel
{
    class TableViewModel
    {
        public List<ListNews> Lists { get; }
        public ListNews[] Data { get; }
        public string[] Stroka { get; set; }
        public TableViewModel()
        {
            var image = new ParserService();
            var count = image.Image.Count;

            Data = new ListNews[count];
            Stroka = new string[count];
            for (var i = 0; i < count; i++)
            {
                Stroka[i] = Regex.Replace(image.Image[i].Value, " [0-9][0-9][0-9][0-9][a-z]", "").Replace("srcset=\"", "");
                Data[i] = new ListNews { SorceImage = Stroka[i] };
            }

            Lists = new List<ListNews>(count);
            Lists.AddRange(Data);
        }
    }
}
