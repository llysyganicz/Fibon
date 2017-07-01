using System.Threading.Tasks;

namespace Fibon.Messages.Events
{
    public interface IEvent
    {
        
    }

    public interface EventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T event);
    }
}