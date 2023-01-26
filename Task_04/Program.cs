/* Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и 
рисует ее в консоли звездочками. (Пример см. презентацию)*/
Console.Clear();
 Console.WriteLine("Насколько высока елочка? ");
            int width = int.Parse(Console.ReadLine()!);
            for (int i = width; i >0; i--)
            {
                for (int j = width - i; j<width; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = width-1; i > 0; i--)
            {
                Console.Write(" ");
            } 
            Console.ReadKey();