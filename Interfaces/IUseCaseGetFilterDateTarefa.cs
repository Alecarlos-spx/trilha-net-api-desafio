using TrilhaApiDesafio.DTO;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseGetFilterDateTarefa
    {
        List<GetTarefaResponse> Execute(DateTime date);
    }
}
