using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TrianguloOrientadoAObjetos
{
    internal class Program
    {
        public int x, y, z;
        static void Main(string[] args)
        {
            while (true)
            {
                Triangulo triangulo = new Triangulo();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite o valor de X");
                    triangulo.x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de Y");
                    triangulo.y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de Z");
                    triangulo.z = Convert.ToInt32(Console.ReadLine());

                    if (triangulo.InvalidacaoDosLados())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("valores inválidos (O comprimento de qual quer um dos lados do triângulo precisa ser menor do que a soma dos outros dois)");
                        Console.ReadLine();
                        Console.ResetColor();
                    }
                } while (triangulo.InvalidacaoDosLados());

                if (triangulo.x == triangulo.y && triangulo.y == triangulo.z)
                {
                    Console.WriteLine("É um triangulo equilátero");
                }
                else if (triangulo.x != triangulo.y && triangulo.y != triangulo.z)
                {
                    Console.WriteLine("É um triangulo escaleno");
                }
                else if (triangulo.ValidacaoTrianguloIsoceles())
                {
                    Console.WriteLine("É um triangulo isóceles");
                }
                Console.ReadLine();
            }



        }
    }
}