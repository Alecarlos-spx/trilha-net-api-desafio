using TrilhaApiDesafio.DTO;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseGetAllTarefas
    {
        List<GetTarefaResponse> Execute();
    }
}
