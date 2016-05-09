using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva um método EhPrimo, de tipo boolean, que recebe um número inteiro e verifica se
 * esse número é primo. Se for, devolve true, senão devolve false. (Dica: para saber se o
 * número é primo, veja quantos divisores o número tem, ou seja, verifique se ele é divisível
 * por 1, por 2, por 3, etc. até ele próprio, e conte quantos divisores são. Se o número de
 * divisores for 2, então ele é primo.) Escreva o método Main que solicita que o usuário
 * digite um valor entre 1 e 100 e depois imprime todos os números primos de 1 até o
 * número digitado. Por exemplo, se o usuário digitou o número 40, o programa deverá
 * exibir todos os números primos entre 1 e 40. (O método Main deverá chamar o método
 * EhPrimo para saber se o número é ou não primo).
 */

namespace PP_Pratica07
{
    class EhPrimo
    {
        public void exibir()
        {
            Console.Write("Digite um número entre 1 a 100:");
            int n = int.Parse(Console.ReadLine());

            if (ehPrimo(n))
            {
                Console.WriteLine("É Primo");

                for (int i = 0; i <= n; i++)
                {
                    if (ehPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Não é Primo");
            }
        }

        public bool ehPrimo(int n)
        {
            int c = 0;
            for (int i = 1; i < (n + 1); i++)
            {
                if (n % i == 0) c++;
            }
            if (c != 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
