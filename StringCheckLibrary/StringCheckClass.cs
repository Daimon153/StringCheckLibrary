using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class StringCheckClass
    {
        /// <summary>
        /// Возвращение букв на лист
        /// </summary>
        /// <param name="textString"></param>
        /// <returns></returns>
        public static List<char> GetLetters(string textString)
        {
            List<char> list = new List<char>();
            foreach(char c in textString)
            {
                list.Add(c);
            }
            return(list);
        }

    }
}
