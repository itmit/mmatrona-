using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Matrona.Service
{
    class ParserService
    {
		#region Fields
		private MatchCollection _title;
		private MatchCollection _span;
		private MatchCollection _image;
		#endregion

		public ParserService()
        {
			try
			{
				var webClient = new WebClient();
				var Response = webClient.DownloadString("https://mmatrona.ru/feed/");
				Span = Regex.Matches(Response, @"<span>(?'text'.*?)</span>");
				Title = Regex.Matches(Response, @"\t\t<title>(?'text'.*?)</title>");

				var respons = webClient.DownloadString("https://mmatrona.ru/raspisanie/");
				Image = Regex.Matches(respons, "srcset=\"(.+?) [0-9][0-9][0-9][0-9][a-z]");
			}
			catch 
			{
				
			}
            
        }

        #region Prop
		public MatchCollection Title
		{
			get => _title; 
			set => _title = value;
		}

		public MatchCollection Span
		{
			get => _span; 
			set => _span = value;
		}

		public MatchCollection Image
		{
			get => _image;
			set => _image = value;
		}
		#endregion

    }
}
