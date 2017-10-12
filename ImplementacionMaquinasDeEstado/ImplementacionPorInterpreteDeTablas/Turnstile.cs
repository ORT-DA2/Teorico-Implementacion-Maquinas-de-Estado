using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionPorInterpreteDeTablas
{
    public enum State { LOCKED, UNLOCKED }
    public enum Event { COIN, PASS }
    public class Turnstile
    {
        // Se maneja una “tabla” en donde se ve un estado inicial, un evento, un estado final y una
        // acción. Dado el estado actual y un evento que ocurre, se puede buscar en la tabla la transición que matchea
        // el estado inicial y el evento que ocurrió, pudiendose de esa forma saber qué acción ejecutar y hacia qué estado final ir

        private State currentState = State.LOCKED;
        private IList<Transition> transitions = new List<Transition>();
        public delegate void Action();

        //En el caso que se quiera agregar transiciones o estados se deben modificar los
        // enumerados y el constructor de Turnstile para haga los nuevos AddTransition
        public Turnstile(TurnstileController controller)
        {
            Action unlockAction = new Action(controller.Unlock);
            Action thankYouAction = new Action(controller.ThankYou);
            Action alarmAction = new Action(controller.Alarm);
            Action lockAction = new Action(controller.Lock);

            AddTransition(State.LOCKED, Event.COIN, State.UNLOCKED, unlockAction);
            AddTransition(State.LOCKED, Event.PASS, State.LOCKED, alarmAction);
            AddTransition(State.UNLOCKED, Event.COIN, State.UNLOCKED, thankYouAction);
            AddTransition(State.UNLOCKED, Event.PASS, State.LOCKED, lockAction);
        }

        private void AddTransition(State sourceState, Event trigger, State destinationState, Action actionToExecute)
        {
            transitions.Add(new Transition(sourceState, trigger, destinationState, actionToExecute));
        }

        public void HandleEvent(Event e)
        {
            foreach (var transition in transitions)
            {
                if (currentState == transition.SourceState  && e == transition.Trigger)
                {
                    currentState = transition.DestinationState;
                    transition.ActionToExecute();
                    break;
                }
            }
        }
    }
}
