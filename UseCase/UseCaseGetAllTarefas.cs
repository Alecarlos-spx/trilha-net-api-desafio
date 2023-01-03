using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseGetAllTarefas : IUseCaseGetAllTarefas
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseGetAllTarefas(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<GetTarefaResponse> Execute()
        {
            var lista_tarefas = _repository.GetAll();

            var response = _mapper.Map<List<GetTarefaResponse>>(lista_tarefas);
            return response;
        }
    }
}
