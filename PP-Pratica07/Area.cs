using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva um método Area que recebe um valor (lado do quadrado) e calcula e devolve a
 * área do quadrado.
 * Escreva um outro método Area que recebe dois valores (base e altura de um retângulo) e
 * calcula e devolve a área do retângulo. Escreva o método Main para testar esses métodos.
 * Teremos 2 métodos com mesmo nome, mas com lista de parâmetros diferentes. Que
 * nome se dá a esse tipo de método?
 * 
 * METODO SOBRECARREGADO
*/

namespace PP_Pratica07
{
    class Area
    {
        public void exibir()
        {
            Console.Write("Digite o tamanho do lado do quadrado:");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("A área do quadrado é: {0}", area(l));

            Console.Write("Digite a base do retangulo:");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Digite a altura do retangulo:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("A área do retangulo é: {0}", area(b,a));
        }
        public float area(float l)
        {
            float area = l * l;
            return area;
        }

        public float area(float b, float a)
        {
            float perimetro = 2 * (b + a);
            return perimetro;
        }
    }
}
