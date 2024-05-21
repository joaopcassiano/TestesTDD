using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesTDD
{
    public class Calculadora
    {
        private List<string> ListaHistorico;

        public Calculadora()
        {
                ListaHistorico = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }
    }
}
