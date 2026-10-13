using System;
using System.Collections.Generic;
using System.Text;

namespace CP20
{
    class AlarmHandler
    {
        public void RingingHandler(object? sender, EventArgs e)
        {
            Console.WriteLine("Будильник сработал!");
        }
    }
}
