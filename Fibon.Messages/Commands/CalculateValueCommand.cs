namespace Fibon.Messages.Commands
{
    public class CalculateValueCommand : ICommand
    {
        public int Number { get; private set; }
        
        protected CalculateValueCommand()
        {
            
        }

        public CalculateValueCommand(int number)
        {
            Number = number;
        }
    }
}