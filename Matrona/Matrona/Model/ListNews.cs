using System;
using System.Collections.Generic;
using System.Text;

namespace Matrona.Model
{
    public class ListNews
    {
		/// <summary>
		/// Возвращает заголовок новости
		/// </summary>
		public string Title
		{
			get; 
			set;
		}

		/// <summary>
		/// Возвращает детальный текст новости
		/// </summary>
		public string Span
		{
			get; 
			set;
		}

		/// <summary>
		/// Возвращает картинку
		/// </summary>
		public string SorceImage
		{
			get; 
			set;
		}
    }
}
