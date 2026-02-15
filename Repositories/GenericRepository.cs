using ActorRepositoryLib2.Interface;

namespace ActorRepositoryLib2.Repositories
{
    public class Repository<T> where T : IEntity
    {
        private readonly List<T> _items = new();
        private int _nextId = 1;

        public List<T> Get()
        {
            return _items.ToList(); // Protect internal list
        }

        public T? GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public T Add(T item)
        {
            item.Id = _nextId++;
            _items.Add(item);
            return item;
        }

        public T? Delete(int id)
        {
            var item = GetById(id);
            if (item == null)
                return default;

            _items.Remove(item);
            return item;
        }

        public T? Update(int id, T data)
        {
            var existing = GetById(id);
            if (existing == null)
                return default;

            // Update logic will be defined later (delegate or interface)
            return existing;
        }
    }
}
