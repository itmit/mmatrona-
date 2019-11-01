using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Matrona.Service
{
    class ParserService
    {
        public MatchCollection Title { get; set; }
        public MatchCollection Span { get; set; }

        public MatchCollection Image { get; set; }
        public ParserService()
        {
            var webClient = new WebClient();
            var Response = webClient.DownloadString("https://mmatrona.ru/feed/");
            Span = Regex.Matches(Response, @"<span>(?'text'.*?)</span>");
            Title = Regex.Matches(Response, @"\t\t<title>(?'text'.*?)</title>");

            var respons = webClient.DownloadString("https://mmatrona.ru/raspisanie/");
            Image = Regex.Matches(respons, "srcset=\"(.+?) [0-9][0-9][0-9][0-9][a-z]");
        }
    }
}
