using TrilhaApiDesafio.DTO;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseUpdateTarefa
    {
        UpdateTarefaResponse Execute(UpdateTarefaRequest request, int id);
    }
}
