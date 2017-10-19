using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionUsandoStatePattern
{
    public class Turnstile
    {
        internal static ITurnstileState lockedState = new LockedTurnstileState();
        internal static ITurnstileState unlockedState = new UnlockedTurnstileState();
        internal static ITurnstileState currentState = unlockedState; // Estado por defecto

        private TurnstileController controller;

        public Turnstile(TurnstileController controller)
        {
            this.controller = controller;
        }

        #region Eventos que pueden dispararse sobre la maquina
        public void Coin()
        {
            // delega al estado interno, no sabe cual es => acoplamiento a nivel de la clase abstracta
            currentState.Coin(this);
        }

        public void Pass()
        {
            // idem arriba
            currentState.Pass(this);
        }
        #endregion

        #region Cambio de estado (lo llama cada subestado como consecuencia de un evento)
        public void SetLocked()
        {
            currentState = lockedState;
        }

        public void SetUnlocked()
        {
            currentState = unlockedState;
        }
        #endregion

        public bool IsLocked()
        {
            return currentState == lockedState;
        }

        public bool IsUnlocked()
        {
            return currentState == unlockedState;
        }

        #region Acciones que se dan en una transicion (al ocurrir un cierto evento)
        public void Alarm()
        {
            controller.Alarm();
        }

        public void ThankYou()
        {
            controller.ThankYou();
        }

        public void Lock()
        {
            controller.Lock();
        }

        public void Unlock()
        {
            controller.Unlock();
        }
        #endregion

    }
}
