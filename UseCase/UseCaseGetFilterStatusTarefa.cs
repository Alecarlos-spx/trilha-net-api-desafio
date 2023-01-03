using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseGetFilterStatusTarefa : IUseCaseGetFilterStatusTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseGetFilterStatusTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<GetTarefaResponse> Execute(EnumStatusTarefa status)
        {
            var lista_tarefas = _repository.GetFilterStatus(status);

            var response = _mapper.Map<List<GetTarefaResponse>>(lista_tarefas);
            return response;
        }
    }
}
