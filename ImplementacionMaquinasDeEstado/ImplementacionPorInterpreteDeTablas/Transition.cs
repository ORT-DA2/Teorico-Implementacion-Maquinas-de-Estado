using static ImplementacionPorInterpreteDeTablas.Turnstile;

namespace ImplementacionPorInterpreteDeTablas
{
    public class Transition
    {
        public State SourceState;
        public Event Trigger;
        public State DestinationState;
        public Action ActionToExecute;

        public Transition(State sourceState, Event trigger, State destinationState, Action actionToExecute)
        {
            SourceState = sourceState;
            Trigger = trigger;
            DestinationState = destinationState;
            ActionToExecute = actionToExecute;
        }
    }
}