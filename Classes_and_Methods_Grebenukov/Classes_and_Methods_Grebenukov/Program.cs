public class Tel
{
    public int day;
    public double time;
    public double price;
    public double Summ()
    {
        double result = time * price;
        if (day == 6 || day == 7)
            return result * 0.9;
        else return result;
    }
}
public class Square
{
    public void Repeat()
    {
        int square;
        for (int i = 1; i <= 10; i++)
        {
            square = Convert.ToInt32(Math.Pow(i, 2));
            Console.Write($"{i}({square})  ");
            StopSquare stop1 = new StopSquare();
            stop1.Stop(square);
        }
    }
}

public class StopSquare
{
    public void Stop(int number)
    {
        if (number > 25)
        {
            Console.WriteLine("Квадрат числа больше 25!");
            
        }
    }
}

public class Program
{
    static void Main()
    {
        static void Exercise1()
        {
            while (true)
            {


                try
                {
                    Tel tel = new Tel();
                    while (tel.day < 1 || tel.day > 7)
                    {
                        Console.Write("Введите день недели разговора: ");
                        tel.day = Convert.ToInt32(Console.ReadLine());
                        if (tel.day < 1 || tel.day > 7) Console.WriteLine("День должен быть от 1 до 7");

                    }
                    Console.Write("Введите время разговора: ");
                    tel.time = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите стоимость минуты:");
                    tel.price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Стоимость разговора: {tel.Summ()} руб");
                    break;
                }
                catch
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
        }
        Exercise1();

        static void Exercise2()
        {
            try
            {
                Square cycle = new Square();
                cycle.Repeat();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        Exercise2();

    }

}