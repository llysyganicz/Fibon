using System.Threading.Tasks;
using Fibon.Messages.Commands;
using Fibon.Messages.Events;
using RawRabbit;

namespace Fibon.Service.Handlers
{
    public class CalculateValueCommandHandler : ICommandHandler<CalculateValueCommand>
    {
        private readonly IBusClient _busClient;
        
        private static int Fib(int n)
        {
            switch (n)
            {
                    case 0: return 0;
                    case 1: return 1;
                    default: return Fib(n - 2) + Fib(n - 1);
            }
        }
        
        public async Task HandleAsync(CalculateValueCommand command)
        {
            var result = Fib(command.Number);

            await _busClient.PublishAsync(new ValueCalculatedEvent(command.Number, result));
        }

        public CalculateValueCommandHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }
    }
}