using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Interfaces
{
    public interface IUseCaseGetFilterStatusTarefa
    {
        List<GetTarefaResponse> Execute(EnumStatusTarefa status);
    }
}
