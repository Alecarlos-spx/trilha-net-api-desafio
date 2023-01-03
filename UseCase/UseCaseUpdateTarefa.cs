using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseUpdateTarefa : IUseCaseUpdateTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseUpdateTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public UpdateTarefaResponse Execute(UpdateTarefaRequest request, int id)
        {
            var tarefa = _mapper.Map<Tarefa>(request);

            _repository.Update(tarefa, id);
            tarefa.Id = id;
            var response = _mapper.Map<UpdateTarefaResponse>(tarefa);

            return response;
        }
    }
}
