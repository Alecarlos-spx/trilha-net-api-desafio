using TrilhaApiDesafio.DTO;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseAddTarefa
    {
        AddTarefaResponse Execute(AddTarefaRequest tarefa);
    }
}
