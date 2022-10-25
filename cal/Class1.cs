using System;
using System.Collections.Generic;
using System.Text;

namespace калькулятор
{
    public class calc
    {

        public string Calcc(int count, double a, string c)
        {
            double b = 0;

            switch (count)
            {
                case 1:
                    b = a + double.Parse(c);
                    return b.ToString();

                case 2:
                    b = a - double.Parse(c);
                    return b.ToString();

                case 3:
                    b = a * double.Parse(c);
                    return b.ToString();

                case 4:

                    if (double.Parse(c) == 0)
                    {
                        return "NOT ÷ 0";
                    }

                    else
                    {
                        b = a / double.Parse(c);
                        return b.ToString();
                    }

                default:
                    break;
            }
            return "0";
        }

    }
}

