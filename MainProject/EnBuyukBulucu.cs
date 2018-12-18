using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProject
{
    public static class EnBuyukBulucu
    {
        public static int EnBuyukBul(int[] sayilar)
        {
            if (sayilar == null)
                return int.MinValue;

            int maxVal = int.MinValue;
            
            for (int i=0; i<sayilar.Length; i++)
            {                
                if(sayilar[i]>maxVal)
                {
                    maxVal = sayilar[i];
                }
            }

            return maxVal;
        }
    }
}
