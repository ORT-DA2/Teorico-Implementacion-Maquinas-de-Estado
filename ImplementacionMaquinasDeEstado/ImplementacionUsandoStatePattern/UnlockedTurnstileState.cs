using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionUsandoStatePattern
{
    public class UnlockedTurnstileState : ITurnstileState
    {
        public void Coin(Turnstile context)
        {
            context.ThankYou();
        }

        public void Pass(Turnstile context)
        {
            context.SetLocked();
            context.Lock();
        }
    }
}
