using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseGetFilterTitleTarefa : IUseCaseGetFilterTitleTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseGetFilterTitleTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<GetTarefaResponse> Execute(string title)
        {
            var lista_tarefas = _repository.GetFilterTitle(title);

            var response = _mapper.Map<List<GetTarefaResponse>>(lista_tarefas);
            return response;
        }

    }
}
