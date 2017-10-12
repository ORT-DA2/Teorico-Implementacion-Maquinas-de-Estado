using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionPorCodigo
{
    public class Turnstile
    {
        // Se implementa a mano. Los estados se pueden implementar con constantes (const int
        //LOCKED = 0; const int UNLOCKED = 1) o con un enum. Luego, los eventos se modelan
        //como métodos de la clase y en cada método se hace un switch del estado actual.

        // States
        public const int LOCKED = 0;
        public const int UNLOCKED = 1;

        // Events
        public const int COIN = 0;
        public const int PASS = 1;

        private int state;
        private TurnstileController turnstileController;

        public Turnstile(TurnstileController controller)
        {
            state = LOCKED;
            turnstileController = controller;
        }

        public void ProcessEvent(int eventToProcess)
        {
            switch (state)
            {
                case LOCKED:
                    ProcessLockedEvent(eventToProcess);
                    break;
                case UNLOCKED:
                    ProcessUnlockedEvent(eventToProcess);
                    break;
                default:
                    break;
            }
        }

        private void ProcessUnlockedEvent(int eventToProcess)
        {
            switch (eventToProcess)
            {
                case COIN:
                    turnstileController.ThankYou();
                    break;
                case PASS:
                    state = LOCKED;
                    turnstileController.Lock();
                    break;
            }
        }

        private void ProcessLockedEvent(int eventToProcess)
        {
            switch (eventToProcess)
            {
                case COIN:
                    state = UNLOCKED;
                    turnstileController.Unlock();
                    break;
                case PASS:
                    turnstileController.Alarm();
                    break;
            }
        }

    }

}
