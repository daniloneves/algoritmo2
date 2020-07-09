using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo2
{
    class ControleAcesso
    {
        public string login = "danilo";
        public string senha = "123";

        public bool EfetuarLogin()
        {
            bool retorno = false;
            Console.WriteLine("Digite o login:");
            string loginDigitado = Console.ReadLine();


            if (loginDigitado == login)
            {
                int count = 0;

                while (count < 3)
                {
                    Console.WriteLine("Digite a senha:");
                    string senhaDigitada = Console.ReadLine();

                    if (senhaDigitada == senha)
                    {
                        retorno = true;
                        break;
                    }

                    count++;
                }
            }

            return retorno;
        }
    }
}
