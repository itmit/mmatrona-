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

		#region Fields
		private List<ListNews> _imageList;
		private ListNews[] _data;
		private string[] _stroka;
		#endregion

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

            ImageList = new List<ListNews>(count);
            ImageList.AddRange(Data);
        }

        #region Prop
		public List<ListNews> ImageList
		{
			get => _imageList;
			set => _imageList = value;
		}

		public ListNews[] Data
		{
			get => _data;
			set => _data = value;
		}

		public string[] Stroka
		{
			get => _stroka; 
			set => _stroka = value;
		}
        #endregion

    }
}
