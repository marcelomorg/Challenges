using Trilha.Model.Models;

namespace Trilh.Persistence.Interfaces
{
    public interface ITask
    {
        public void Add<T>(T entity) where T : class;
        public void Update<T>(T entityNew) where T : class;
        public void Delete<T>(T entity) where T : class;

        public bool SaveChanges();

        public List<Tarefa> GetTaskAll();
        public Tarefa GetTaskById(int id);
        public Task<Tarefa[]> GetTaskByTitulo(string titulo);
        public Task<Tarefa[]> GetTaskByData(DateOnly data);
        public Task<Tarefa[]> GetTaskByStatus(int status);
    }
}