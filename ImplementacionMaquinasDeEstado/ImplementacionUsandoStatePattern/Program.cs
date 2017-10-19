using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionUsandoStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TurnstileController controller = new TurnstileController();
            Turnstile turnstile = new Turnstile(controller);

            turnstile.Coin(); // Imprime: Desbloqueado!
            turnstile.Pass(); // Imprime: Te bloqueo!
            turnstile.Pass(); // Imprime: ALARMAAAAAAAAAAAA!

            Console.ReadKey();
        }
    }
}
