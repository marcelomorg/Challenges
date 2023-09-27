

using Microsoft.EntityFrameworkCore;
using Trilh.Persistence.Interfaces;
using Trilha.Model.Models;
using Trilha.Persistence.Contexts;

namespace Trilha.Persistence
{
    public class TaskPersist : ITask
    {
        private TrilhaContext _context { get; set; }
        public TaskPersist(TrilhaContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //AsNoTranking() can used in methods else used on _context.
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entityNew) where T : class
        {   
            // This method can be used if the entity is not traking
            // _context.Entry(entityOld).CurrentValues.SetValues(entityNew);
            _context.Update(entityNew);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public List<Tarefa> GetTaskAll()
        {
            List<Tarefa> list = _context.Tarefas.ToList();
            return  list;
        }

        public Task<Tarefa[]> GetTaskByData(DateOnly data)
        {
            throw new NotImplementedException();
        }

        public Tarefa GetTaskById(int id)
        {
            var result = _context.Tarefas.Where(x => x.Id == id).ToList();
            Tarefa tarefa = new Tarefa();
            foreach (var x in result)
            {
                tarefa.Id = x.Id;
                tarefa.Titulo = x.Titulo;
                tarefa.Descricao = x.Descricao;
                tarefa.Data = x.Data;
                tarefa.Status = x.Status;
            }
            return  tarefa;
        }

        public Task<Tarefa[]> GetTaskByStatus(int status)
        {
            throw new NotImplementedException();
        }

        public Task<Tarefa[]> GetTaskByTitulo(string titulo)
        {
            throw new NotImplementedException();
        }


        public bool SaveChanges()
        {
            var result = _context.SaveChanges()  > 0;
            return result;
        }
    }
}