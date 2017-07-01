using System.Collections.Generic;

namespace Fibon.API.Repository
{
    public class InMemoryRepository : IRepository
    {
        private readonly Dictionary<int, int> _storage = new Dictionary<int, int>();
        
        public void Add(int number, int result)
        {
            _storage.Add(number, result);
        }

        public int? Get(int number)
        {
            int value;
            if (_storage.TryGetValue(number, out value))
                return value;

            return null;
        }
    }
}