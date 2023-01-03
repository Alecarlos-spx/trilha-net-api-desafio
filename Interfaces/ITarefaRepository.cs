using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Interfaces
{
    public interface ITarefaRepository
    {
        public Tarefa GetById(int id);
        public Tarefa Update(Tarefa request, int id);
        public bool Delete(int id);
        public List<Tarefa> GetAll();
        public List<Tarefa> GetFilterTitle(string title);
        public List<Tarefa> GetFilterDate(DateTime date);
        public List<Tarefa> GetFilterStatus(EnumStatusTarefa status);
        public Tarefa Add(Tarefa request);


    }
}
