using System;

namespace ImplementacionUsandoStatePattern
{
    public class TurnstileController
    {
        public void ThankYou()
        {
            Console.WriteLine("Gracias!");
        }
        public void Alarm()
        {
            Console.WriteLine("ALARMAAAAAAAAAAAA!");
        }
        public void Lock()
        {
            Console.WriteLine("Te bloqueo!");
        }

        public void Unlock()
        {
            Console.WriteLine("Desbloqueado!");
        }
    }
}