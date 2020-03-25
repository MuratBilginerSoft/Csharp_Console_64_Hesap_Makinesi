using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Cikar
    {
        public void Çıkarma(int S1, int S2)
        {
            if (S1>S2)
            {
                Console.WriteLine("Sonuç={0}", S1 - S2);
            }

            else
            {
                Console.WriteLine("Sonuç={0}", S2- S1);
            }

        }
    }
}
