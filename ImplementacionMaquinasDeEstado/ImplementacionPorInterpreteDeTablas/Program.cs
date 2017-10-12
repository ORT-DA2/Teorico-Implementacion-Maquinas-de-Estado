using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionPorInterpreteDeTablas
{
    class Program
    {
        static void Main(string[] args)
        {
            TurnstileController controller = new TurnstileController();
            Turnstile turnstile = new Turnstile(controller);

            turnstile.HandleEvent(Event.COIN); // Imprime: Desbloqueado!
            turnstile.HandleEvent(Event.PASS); // Imprime: Te bloqueo!
            turnstile.HandleEvent(Event.PASS); // Imprime: ALARMAAAAAAAAAAAA!

            Console.ReadKey();
        }
    }
}
