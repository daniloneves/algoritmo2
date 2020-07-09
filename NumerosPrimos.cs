using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo2
{
    class NumerosPrimos
    {
        public int limite { get; set; }
        public int[] indices = new int[4];

        public NumerosPrimos() 
        {
            indices[0] = 2;
            indices[1] = 3;
            indices[2] = 5;
            indices[3] = 7;
        }

        public void CalcularNumerosPrimos()
        {
            for (int l = 1; l <= limite; l++) //varrendo todo os números até o limite informado pelo usuário
            {
                bool primo = true;

                for (int i = 0; i < 4; i++)
                {
                    int resto = l % indices[i];

                    if (l != indices[i] && resto == 0)
                    {
                        primo = false;
                        break;
                    }

                }

                if (primo)
                    Console.WriteLine(l);
            }
        }
    }
}
