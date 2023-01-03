using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseAddTarefa : IUseCaseAddTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseAddTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public AddTarefaResponse Execute(AddTarefaRequest request)
        {
            var tarefa = _mapper.Map<Tarefa>(request);

            _repository.Add(tarefa);
            
            var response = _mapper.Map<AddTarefaResponse>(tarefa);

            return response;
        }
    }
}
