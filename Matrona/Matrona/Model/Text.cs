using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Matrona.Model
{
    class Text
    {
        public static string Str()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            foreach (var str in assembly.GetManifestResourceNames())
            {
                if (str.Contains("TextFile1.txt"))
                {
                    Stream stream = assembly.GetManifestResourceStream(str);
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        string sroka = sr.ReadToEnd();
                        return sroka;
                    }
                }
            }
            return null;
        }
    }
}
