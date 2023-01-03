using TrilhaApiDesafio.DTO;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseGetTarefa
    {
        GetTarefaResponse Execute(int id);
    }
}
