using System;

namespace CP20
{
    class Program
    {
        static void Main()
        {
            AlarmClock alarm = new AlarmClock();
            AlarmHandler handler = new AlarmHandler();

            alarm.Ringing += handler.RingingHandler;

            Console.WriteLine("\nЗапускаем будильник:");
            alarm.Trigger();

            alarm.Ringing -= handler.RingingHandler;

            Console.WriteLine("\nЗапускаем будильник повторно:");
            alarm.Trigger();

            Console.WriteLine("Будильник не сработал, так как обработчик отписан.");

            Console.WriteLine("\nПроверка завершена.");

            Console.ReadLine();
        }
    }
}