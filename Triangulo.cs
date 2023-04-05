using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOrientadoAObjetos
{
    public class Triangulo
    {
        public int x, y, z;

        public bool InvalidacaoDosLados()
        {
            return x + y < z || x + z < y || z + y < x;
        }
        public bool ValidacaoTrianguloIsoceles()
        {
            return x !=  y && z == x || z != x && y == z || y != z && y == x;
        }
    }
}
