using System;
using System.Collections.Generic;
using System.Text;

namespace CP20
{
    class AlarmClock
    {
        private EventHandler? ringing;

        public event EventHandler? Ringing
        {
            add
            {
                ringing += value;
                Console.WriteLine("Новая подписка на событие.");
            }
            remove
            {
                ringing -= value;
                Console.WriteLine("Отписка от события.");
            }
        }

        public void Trigger()
        {
            ringing?.Invoke(this, EventArgs.Empty);
        }
    }
}
