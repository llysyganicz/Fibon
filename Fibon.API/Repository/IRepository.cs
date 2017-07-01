namespace Fibon.API.Repository
{
    public interface IRepository
    {
        void Add(int number, int result);
        int? Get(int number);
    }
}