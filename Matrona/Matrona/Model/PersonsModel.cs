using System;
using System.Collections.Generic;
using System.Text;

namespace Matrona.Model
{
    public class PersonsModel
    {
        /// <summary>
        /// Возвращает картинку
        /// </summary>
        public string Image 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Возвращает заголовок
        /// </summary>
        public string TitleText 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Возвращает детальный текст
        /// </summary>
        public string DetailText 
        { 
            get; 
            set; 
        }
    }
}
