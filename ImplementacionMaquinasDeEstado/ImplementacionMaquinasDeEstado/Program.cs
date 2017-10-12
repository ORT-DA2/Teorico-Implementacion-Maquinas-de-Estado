using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionPorCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            TurnstileController controller = new TurnstileController();
            Turnstile turnstile = new Turnstile(controller);

            turnstile.ProcessEvent(Turnstile.COIN); // Imprime: Desbloqueado!
            turnstile.ProcessEvent(Turnstile.PASS); // Imprime: Te bloqueo!
            turnstile.ProcessEvent(Turnstile.PASS); // Imprime: ALARMAAAAAAAAAAAA!

            Console.ReadKey();
        }
    }
}
