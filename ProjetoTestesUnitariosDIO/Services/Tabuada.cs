using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTestesUnitariosDIO.Services
{
    public class Tabuada
    {
        
        public float Tabuada2(int num, string operacao)
        {
            float res = 0;
            switch (operacao)
            {
                case "+":
                    res = num + 2;
                    break;
                case "-":
                    res = num - 2;
                    break;
                case "*":
                    res = num * 2;
                    break;
                case "/":
                    res = num / 2;
                    break;
                default:
                    break;
            }

            return res;
        }

        public float Tabuada3(int num, string operacao)
        {
            float res = 0;
            switch (operacao)
            {
                case "+":
                    res = num + 3;
                    break;
                case "-":
                    res = num - 3;
                    break;
                case "*":
                    res = num * 3;
                    break;
                case "/":
                    res = num / 3;
                    break;
                default:
                    break;
            }

            return res;
        }

        public float Tabuada4(int num, string operacao)
        {
            float res = 0;
            switch (operacao)
            {
                case "+":
                    res = num + 4;
                    break;
                case "-":
                    res = num - 4;
                    break;
                case "*":
                    res = num * 4;
                    break;
                case "/":
                    res = num / 4;
                    break;
                default:
                    break;
            }

            return res;
        }

        public float Tabuada5(int num, string operacao)
        {
            float res = 0;
            switch (operacao)
            {
                case "+":
                    res = num + 5;
                    break;
                case "-":
                    res = num - 5;
                    break;
                case "*":
                    res = num * 5;
                    break;
                case "/":
                    res = num / 5;
                    break;
                default:
                    break;
            }

            return res;
        }

    }
}
