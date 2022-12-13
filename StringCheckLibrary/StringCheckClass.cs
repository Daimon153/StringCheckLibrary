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
            textString = textString.ToUpper();

            foreach(char c in textString)
            {// проверка на уникальность символа    
                if(list.Contains(c))
                {
                    
                    list.Add(c);

                }
                
            }
            return(list);
        }

    }
}
