using ActorRepositoryLib2.Models;
namespace ActorRepositoryLib2.Repositories
{
    public class ActorsRepository
    {
        private readonly List<Actor> _actor;
        private int _nextId = 1;
        public ActorsRepository()
        {
            _actor = new List<Actor>();
            _nextId = 1;
        }

        public List<Actor> Get()
        {
            return _actor;
        }

        public Actor? GetById(int id)
        {
            foreach (var actor in _actor)
            {
                if (actor.Id == id)
                {
                    return actor;
                }

            }
            return null;

        }

        public Actor Add(Actor actor)
        {
            actor.Id = _nextId++;
            _actor.Add(actor);
            return actor;
        }

        public Actor Delete(int id)
        {
            var actor = GetById(id);
            if (actor != null)
            {
                _actor.Remove(actor);
                return actor;
            }
            return null;
        }
        public Actor Update(int id, Actor data)
        {
            var actor = GetById(id);
            if (actor != null)
            {
                actor.Name = data.Name;
                actor.BirthYear = data.BirthYear;
                actor.Country = data.Country;
                actor.Movies = data.Movies;
                return actor;
            }
            return null;
        }
    }
}
