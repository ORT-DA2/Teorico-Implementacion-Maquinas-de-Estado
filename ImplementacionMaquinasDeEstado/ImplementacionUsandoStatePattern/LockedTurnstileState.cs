using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionUsandoStatePattern
{
    public class LockedTurnstileState : ITurnstileState
    {
        public void Coin(Turnstile context)
        {
            context.SetUnlocked();
            context.Unlock();
        }

        public void Pass(Turnstile context)
        {
            context.Alarm();
        }

    }
}
