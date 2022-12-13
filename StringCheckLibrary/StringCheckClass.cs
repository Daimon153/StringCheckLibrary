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
        /// <param name="textString">
        /// В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. Текст может включать в себя произвольные символы.</param>
        /// <returns>Возвращается список символов List<char>. Список должен содержать буквы искомого текста и удовлетворять требованиям, указанным выше.</returns>
        public static List<char> GetLetters(string textString)
        {
            List<char> list = new List<char>();
            //заглавные буквы
            textString = textString.ToUpper();
            
            foreach(char c in textString)
            {// проверка на уникальность символа    
                if(list.Contains(c))
                {
                    
                    list.Add(c);

                }
                
            }
            //отсортировка
            list.Sort();
            //возвращение листа
            return(list);
        }

    }
}
