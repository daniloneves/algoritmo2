using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Controle de acesso
            //ControleAcesso controleAcesso = new ControleAcesso();
            //bool logado = controleAcesso.EfetuarLogin();
            //if (logado)
            //    Console.WriteLine("LOGIN EFETUADO COM SUCESSO!");




            //Números primos
            NumerosPrimos numerosPrimos = new NumerosPrimos();
            Console.WriteLine("Digite um limite: ");
            numerosPrimos.limite = Convert.ToInt32(Console.ReadLine());
            numerosPrimos.CalcularNumerosPrimos();




            //Cálculo de IMC
            //Console.WriteLine("Digite o seu peso (Kg):");
            //int peso = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite a sua altura (m):");
            //double altura = Convert.ToDouble(Console.ReadLine());

            //double imc = peso / (altura * altura);
            //string resultado = "";

            //if (imc < 17)
            //    resultado = "Muito abaixo do peso";

            //if (imc >= 17 && imc <= 18.49)
            //    resultado = "Abaixo do peso";

            //if (imc > 18.49 && imc < 25)
            //    resultado = "Peso normal";

            //if (imc > 25 && imc < 30)
            //    resultado = "Acima do peso";

            //if (imc >= 30 && imc < 35)
            //    resultado = "Obesidade I";

            //if (imc >= 35 && imc < 40)
            //    resultado = "Obesidade II (severa)";

            //if (imc >= 40)
            //    resultado = "Obesidade III (mórbida)";

            //Console.WriteLine(resultado);
        }
    }
}
