namespace Fibon.Messages.Events
{
    public class ValueCalculatedEvent : IEvent
    {
        public int Number { get; private set; }
        public int Value { get; private set; }

        protected ValueCalculatedEvent()
        {
            
        }

        public ValueCalculatedEvent(int number, int value)
        {
            Number = number;
            Value = value;
        }
    }
}