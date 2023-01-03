using TrilhaApiDesafio.DTO;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseGetFilterTitleTarefa
    {
        List<GetTarefaResponse> Execute(string title);
    }
}
