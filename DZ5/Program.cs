using System;

namespace DZ5
{
    enum Figur {krug = 1, triugolnik, pryamougolnik}
    class Program
    {
        static void Main(string[] args)
        {
           Start:
            Console.WriteLine("Введите тип фигуры:");
            int namber = int.Parse(Console.ReadLine());
            Figur figur = (Figur)namber;
            
          
            if (namber < 1 || namber > 3)
            {
                throw new Exception("Введенное значение выходит за допустимые пределы от 1 до 3!");
                Console.WriteLine("Вы ввели не верное значение!");
                goto Start;
                return;
            }


            switch (figur)
            {
                case Figur.krug:
                    Console.WriteLine("Введите деаметр:");
                    double a = double.Parse(Console.ReadLine());
                    double value1 = 0;
                    double value2 = 0;
                    value1 = Math.PI * a;
                    value2 = Math.PI * Math.Pow(a / 2, 2);
                    Console.WriteLine("Периметер равен: {0}", value1);
                    Console.WriteLine("Площадь равна: {0}", value2);
                    break;
                case Figur.triugolnik:
                    Console.WriteLine("Введите длинну стороны:");
                    double b = double.Parse(Console.ReadLine());
                    double val1 = 0;
                    double val2= 0;
                    val1 = b * 3;
                    val2 = b / 2 * Math.Sqrt(3) / 2 * b;
                    Console.WriteLine("Периметер равен: {0}", val1);
                    Console.WriteLine("Площадь равна: {0}", val2);
                    break;
                case Figur.pryamougolnik:
                    Console.WriteLine("Введите ширину прямоугольника:");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите высоту прямоугольника:");
                    double c = double.Parse(Console.ReadLine());
                    double valu1 = 0;
                    double valu2 = 0;
                    valu1 = 2 * (d + c);
                    valu2 = d * c;
                    Console.WriteLine("Периметер равен: {0}", valu1);
                    Console.WriteLine("Площадь равна: {0}", valu2);
                    break;
                   
            }


            Console.ReadKey();

    }
            
                
           
            
          
    }
}
