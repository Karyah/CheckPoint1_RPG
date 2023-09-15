using CheckPoint1_RPG.Models;

namespace CheckPoint1_RPG.Persistence
{
    public interface IPersonagemRepository
    {
        Personagem getById(int id);

        IEnumerable<Personagem> getAll();

        void Add(Personagem entity);

        void Update(Personagem entity);

        void Delete(Personagem entity);

    }
}
