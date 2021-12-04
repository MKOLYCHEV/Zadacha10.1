using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int grad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите угловые секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            ConvertGrad convert = new ConvertGrad(grad,min,sec);
            convert.ToRadians(out double rad);
            Console.WriteLine("Угол в радианах равен {0:0.#####}.",rad);
            Console.ReadKey();
        }
    }
    class ConvertGrad
    {
        int grad;
        int min;
        int sec;
        public int Grad
        {
            set
            {
                if (value >= 0 && value <= 360) grad = value;
                else 
                {
                    Console.WriteLine("Ошибка! Значение градусов должно быть в пределах от 0 до 360. Введенное значение обнулено.");
                    grad = 0;
                }     
            }
            get
            {
                return grad;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60) min = value;
                else
                {
                    Console.WriteLine("Ошибка! Значение угловых минут должно быть в пределах от 0 до 60. Введенное значение обнулено.");
                    min = 0;
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60) sec = value;
                else 
                {
                    Console.WriteLine("Ошибка! Значение угловых секунд должно быть в пределах от 0 до 60. Введенное значение обнулено.");
                    sec = 0;
                }
            }
            get
            {
                return sec;
            }
        }
        public ConvertGrad(int grad, int min = 0, int sec = 0)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public void ToRadians(out double Rad)
        {
            Rad = grad * Math.PI / 180 + min * Math.PI / (180 * 60) + sec * Math.PI / (180 * 60 * 60);
        }
    }
}
