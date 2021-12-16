using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7._1
{
    public class BCoder : ICoder
    {
        char[] abc = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                      'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т',
                      'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                      'Э', 'Ю', 'Я'};

        StringBuilder sb = new StringBuilder();
        int num;
        const int numMin = 1;
        const int numMax = 33;
        bool isUpper = true;
        char up;
        public string Encode(string strChar)
        {
            foreach (var i in strChar)
            {
                num = 0;
                isUpper = char.IsUpper(i);
                if (!isUpper)
                {
                    up = char.ToUpper(i);
                }
                else
                {
                    up = i;
                }

                foreach (var iAbc in abc)
                {
                    num++;
                    if (up == iAbc)
                    {

                        if (isUpper)
                        {
                            sb.Append(abc[numMax - num]);
                        }
                        else
                        {
                            up = char.ToLower(abc[numMax - num]);
                            sb.Append(up);
                        }

                    }
                }
            }

            return sb.ToString();
        }

        public void Clear()
        {
            sb.Clear();
        }

        public string Decode(string strChar)
        {
            return Encode(strChar);
        }
    }
}
