using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseGetFilterDateTarefa : IUseCaseGetFilterDateTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseGetFilterDateTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<GetTarefaResponse> Execute(DateTime date)
        {
            var lista_tarefas = _repository.GetFilterDate(date);

            var response = _mapper.Map<List<GetTarefaResponse>>(lista_tarefas);
            return response;
        }
    }
}
