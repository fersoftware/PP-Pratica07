using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método CalculaImc (float peso, float altura ), que retorna um valor float.
 * Esse método calcula e devolve o valor do IMC, que é o índice de massa corporal de uma
 * pessoa, e é calculado através da fórmula:
 * IMC = peso / (altura * altura)
 * Por exemplo, uma pessoa de altura 1,60 m e peso 57 kg, tem
 * IMC = 57 / (1,60 * 1,60) = 22,26
 * Esse método exibe o status da pessoa, segundo a tabela abaixo:
 * IMC Status
 * Até 18,4 “Abaixo do peso”
 * De 18,5 a 24,9 “Normal”
 * De 25,0 a 29,9 “Sobrepeso”
 * Acima de 30,0 “Obeso”
 * Na classe Program, dentro do método Main, leia os dados de 5 pessoas (peso e altura),
 * chame o método CalculaImc para obter os IMCs dessas pessoas e exiba a média dos IMCs
 * calculados.
 */
namespace PP_Pratica07
{
    class CalculaIMC
    {
        public void exibir()
        {
            Console.Write("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());
            float IMC = CalculaImc(peso, altura);
            status(IMC);           
        }
        public float CalculaImc(float peso, float altura)
        {
            float IMC = peso / (altura * altura);
            return IMC;
        }

        public void status(float IMC)
        {
            Console.WriteLine("IMC Status");
            Console.WriteLine("Até 18,4 “Abaixo do peso”");
            Console.WriteLine("De 18,5 a 24,9 “Normal”");
            Console.WriteLine("De 25,0 a 29,9 “Sobrepeso”");
            Console.WriteLine("Acima de 30,0 “Obeso”");

            if (IMC <= 18.4)
            {
                Console.WriteLine("Seu IMC é {0} e você está abaixo do peso", IMC);
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Seu IMC é {0} e você está no peso normal", IMC);
            }
            else if (IMC >= 20.0 && IMC <= 29.9)
            {
                Console.WriteLine("Seu IMC é {0} e você está Sobrepreso", IMC);
            }
            else if (IMC >= 30.0)
            {
                Console.WriteLine("Seu IMC é {0} e você está Obeso", IMC);
            }
        }
    }
}
