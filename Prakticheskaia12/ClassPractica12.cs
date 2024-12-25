using System.Windows;

namespace Prakticheskaia12
{
    class Zadanie1
    {
        public double katet1;
        public double katet2;

        public void SetParams(int one, int two)
        {
            katet1 = one;
            katet2 = two;
        }
        public double Gipotenyza()
        {
            double result = Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));
            return result;
        }
    }
    class Zadanie2
    {
        public int chislo;

        private int Chislo
        {
            get
            {
                return chislo;
            }
            set
            {
                if (value > 999) chislo = value;
                else MessageBox.Show("Введите число большее 999");
            }
        }
        public void SetParams(int one)
        {
            Chislo = one;
        }
        public int RazradSoten()
        {
            int result = (chislo / 100) % 10;
            return result;
        }

    }
}
