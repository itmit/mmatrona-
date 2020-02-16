using System;
using Matrona.Model;
using Matrona.Service;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Matrona.ViewModel
{
    class ListViewModel
    {

		#region Fields
		private List<ListNews> _lists;
		private ListNews[] _data;
		private string[] _title;
		private string[] _span;
		#endregion

		public ListViewModel()
        {
			try
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
			catch
			{
				
			}
        }

        #region Prop
		public List<ListNews> Lists
		{
			get => _lists;
			set => _lists = value;
		}

		public ListNews[] Data
		{
			get => _data; 
			set => _data = value;
		}

		public string[] Title
		{
			get => _title; 
			set => _title = value;
		}

		public string[] Span
		{
			get => _span; 
			set => _span = value;
		}
        #endregion

    }
}
