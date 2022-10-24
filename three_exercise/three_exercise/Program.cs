using System;

class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер масти карты: 1-пик, 2-крести, 3-бубен, 4-червь");
            int cardNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите номер достоинства карты:");
            int cardDig = Convert.ToInt32(Console.ReadLine());

            switch (cardDig)
            {
                case 6: Console.Write("Шестерка"); 
                    break;
                case 7: Console.Write("Семерка"); 
                    break;
                case 8: Console.Write("Восьмерка"); 
                    break;
                case 9: Console.Write("Девятка"); 
                    break;
                case 10: Console.Write("Десятка"); 
                    break;
                case 11: Console.Write("Валет"); 
                    break;
                case 12: Console.Write("Дама"); 
                    break;
                case 13: Console.Write("Король"); 
                    break;
                case 14: Console.Write("Туз"); 
                    break;
            }
            switch (cardNum)
            {
                case 1: Console.Write(" пик"); 
                    break;
                case 2: Console.Write(" крести"); 
                    break;
                case 3: Console.Write(" бубен"); 
                    break;
                case 4: Console.Write(" червей"); 
                    break;
            }


        }
 }
