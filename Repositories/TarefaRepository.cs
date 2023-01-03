using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly OrganizadorContext _context;
        public TarefaRepository(OrganizadorContext context)
        {
            _context = context;
        }

        public Tarefa Add(Tarefa request)
        {
            _context.Add(request);

            _context.SaveChanges();

            return request;
        }



        public bool Delete(int id)
        {
            var tarefa = this.GetById(id);

            if (tarefa == null)
                return false;

            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();

            return true;

        }

        public Tarefa GetById(int id)
        {
            var tarefaBanco = _context.Tarefas.Where(t => t.Id == id).FirstOrDefault();

            return tarefaBanco;
        }

        public List<Tarefa> GetAll()
        {
            var tarefaBanco = _context.Tarefas.ToList();

            return tarefaBanco;
        }

        public List<Tarefa> GetFilterDate(DateTime date)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == date.Date).ToList();

            return tarefa;
        }

        public List<Tarefa> GetFilterStatus(EnumStatusTarefa status)
        {
            var tarefa = _context.Tarefas.Where(x => x.Status == status).ToList();

            return tarefa;
        }

        public List<Tarefa> GetFilterTitle(string title)
        {
            var tarefa = _context.Tarefas.Where(x => x.Titulo.Contains(title)).ToList();

            return tarefa;
        }

        public Tarefa Update(Tarefa request, int id)
        {
            var tarefa = this.GetById(id);

            if (tarefa != null)
            {
                request.Id = id;
                _context.Entry(tarefa).CurrentValues.SetValues(request);
                _context.Tarefas.Update(tarefa);
                _context.SaveChanges();
            }

            return tarefa;

        }
    }
}
