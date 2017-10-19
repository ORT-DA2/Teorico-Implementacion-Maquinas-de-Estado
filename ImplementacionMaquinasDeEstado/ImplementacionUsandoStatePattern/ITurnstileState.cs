using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionUsandoStatePattern
{
    // Interfaz de operaciones que van a implementar cada estado
    // A pensar: todas estas operaciones aplican a todas los estados?
    public interface ITurnstileState
    {
        void Coin(Turnstile context);
        void Pass(Turnstile context);
    }
}
