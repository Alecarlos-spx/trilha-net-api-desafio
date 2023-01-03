using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseGetTarefa : IUseCaseGetTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseGetTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public GetTarefaResponse Execute(int id)
        {
            var tarefa = _repository.GetById(id);

            var response = _mapper.Map<GetTarefaResponse>(tarefa);
            return response;
        }
    }
}
