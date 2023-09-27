

using Microsoft.AspNetCore.Mvc;
using Trilh.Persistence.Interfaces;
using Trilha.Model.Models;
using Trilha.Persistence;

namespace Trilha.Service.Controllers
{
    public class TaskController : Controller
    {
        private ITask taskPersist { get; set; }
        public TaskController (ITask taskpersist)
        {
            taskPersist = taskpersist;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            List<Tarefa> result = new List<Tarefa>(taskPersist.GetTaskAll());
            return View(result);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]    
        public IActionResult Create(Tarefa tarefa)
        {
            Console.WriteLine($"ID: {tarefa.Id}\nTITULO: {tarefa.Titulo}\nDESCRICAO: {tarefa.Descricao}\nDATA: {tarefa.Data}\nSTATUS: {tarefa.Status}");
            taskPersist.Add(tarefa);
            taskPersist.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update()
        {
            List<Tarefa> list = new List<Tarefa>(taskPersist.GetTaskAll());
            return View(list);
        }

        public IActionResult UpdateEdit(int id)
        {
            var result = taskPersist.GetTaskById(id);
            return View(result);
        }

        public IActionResult UpdateEditTwo(Tarefa tarefaNew)
        {
            taskPersist.Update(tarefaNew);
            taskPersist.SaveChanges();
            return RedirectToAction(nameof(Update));
        }

        public IActionResult Erase()
        {
            List<Tarefa> list = new List<Tarefa>(taskPersist.GetTaskAll());
            return View(list);
        }

        public IActionResult EraseEdit(int id)
        {
            Console.WriteLine("ID of return: "+id);
            var result = taskPersist.GetTaskById(id);
            Console.WriteLine($"ID: {result.Id}\nTITULO: {result.Titulo}\nDESCRICAO: {result.Descricao}\nDATA: {result.Data}\nSTATUS: {result.Status}");
            taskPersist.Delete(result);
            taskPersist.SaveChanges();
            return RedirectToAction(nameof(Erase));
        }
    }
}