using System.Threading.Tasks;

namespace Fibon.Messages.Commands
{
    public interface ICommand
    {
        
    }

    public interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}