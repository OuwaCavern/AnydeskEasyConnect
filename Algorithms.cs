using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnydeskEasyConnect
{
    internal class Algorithms
    {
        internal static string AnydeskNumarasiDuzenleyici(string orijinalAnydeskNumarasi)
        {
            string formatlanmisAnydeskNumarasi = "";
            char[] orijinalAnydeskNumarasiArray = orijinalAnydeskNumarasi.ToCharArray();
            if (orijinalAnydeskNumarasi.Length == 9)
            {
                for (int i = 0; i < orijinalAnydeskNumarasiArray.Length; i++)
                {
                    if (i == 3 || i == 6)
                    {
                        formatlanmisAnydeskNumarasi += ' ';
                        formatlanmisAnydeskNumarasi += orijinalAnydeskNumarasiArray[i];
                    }
                    else
                    {
                        formatlanmisAnydeskNumarasi += orijinalAnydeskNumarasiArray[i];
                    }
                }
            }
            if (orijinalAnydeskNumarasi.Length == 10)
            {
                formatlanmisAnydeskNumarasi += orijinalAnydeskNumarasiArray[0];
                formatlanmisAnydeskNumarasi += ' ';
                for (int i = 1; i < orijinalAnydeskNumarasiArray.Length; i++)
                {
                    if (i == 4 || i == 7)
                    {
                        formatlanmisAnydeskNumarasi += ' ';
                        formatlanmisAnydeskNumarasi += orijinalAnydeskNumarasiArray[i];
                    }
                    else
                    {
                        formatlanmisAnydeskNumarasi += orijinalAnydeskNumarasiArray[i];
                    }
                }
            }
            return formatlanmisAnydeskNumarasi;
        }
    }
}
