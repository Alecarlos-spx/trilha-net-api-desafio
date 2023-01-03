using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.UseCase
{
    public class UseCaseDeleteTarefa : IUseCaseDeleteTarefa
    {
        private readonly IMapper _mapper;
        private readonly ITarefaRepository _repository;

        public UseCaseDeleteTarefa(IMapper mapper, ITarefaRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public bool Execute(int id)
        {
            var response = _repository.Delete(id);

            return response;
        }
    }
}
