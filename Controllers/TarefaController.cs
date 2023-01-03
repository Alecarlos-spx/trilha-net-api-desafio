using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.Models;


namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly IUseCaseAddTarefa _useCaseAddTarefa;
        private readonly IUseCaseUpdateTarefa _useCaseUpdateTarefa;
        private readonly IUseCaseDeleteTarefa _useCaseDeleteTarefa;
        private readonly IUseCaseGetTarefa _useCaseGetTarefa;
        private readonly IUseCaseGetAllTarefas _useCaseGetAllTarefas;
        private readonly IUseCaseGetFilterDateTarefa _useCaseGetFilterDateTarefa;
        private readonly IUseCaseGetFilterStatusTarefa _useCaseGetFilterStatusTarefa;
        private readonly IUseCaseGetFilterTitleTarefa _useCaseGetFilterTitleTarefa;

        public TarefaController(IUseCaseAddTarefa useCaseAddTarefa, 
                                IUseCaseUpdateTarefa useCaseUpdateTarefa, 
                                IUseCaseDeleteTarefa useCaseDeleteTarefa, 
                                IUseCaseGetTarefa useCaseGetTarefa, 
                                IUseCaseGetAllTarefas useCaseGetAllTarefas, 
                                IUseCaseGetFilterDateTarefa useCaseGetFilterDateTarefa, 
                                IUseCaseGetFilterStatusTarefa useCaseGetFilterStatusTarefa, 
                                IUseCaseGetFilterTitleTarefa useCaseGetFilterTitleTarefa)
        {
            _useCaseAddTarefa = useCaseAddTarefa;
            _useCaseUpdateTarefa = useCaseUpdateTarefa;
            _useCaseDeleteTarefa = useCaseDeleteTarefa;
            _useCaseGetTarefa = useCaseGetTarefa;
            _useCaseGetAllTarefas = useCaseGetAllTarefas;
            _useCaseGetFilterDateTarefa = useCaseGetFilterDateTarefa;
            _useCaseGetFilterStatusTarefa = useCaseGetFilterStatusTarefa;
            _useCaseGetFilterTitleTarefa = useCaseGetFilterTitleTarefa;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var response = _useCaseGetTarefa.Execute(id);

            if (response != null)
                return Ok(response);
            else
                return NotFound();
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var response = _useCaseGetAllTarefas.Execute();

            if (response != null && response.Count > 0)
                return Ok(response);
            else
                return NotFound();
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            var response = _useCaseGetFilterTitleTarefa.Execute(titulo);
            if (response != null && response.Count > 0)
                return Ok(response);
            else
                return NotFound();
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var response = _useCaseGetFilterDateTarefa.Execute(data);
            if (response != null && response.Count > 0)
                return Ok(response);
            else
                return NotFound();

        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var response = _useCaseGetFilterStatusTarefa.Execute(status);
            if (response != null && response.Count > 0)
                return Ok(response);
            else
                return NotFound();

        }

        [HttpPost]
        public IActionResult Criar(AddTarefaRequest tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

           // return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);

           // if (!ModelState.IsValid)
           //     return BadRequest();

            var response = _useCaseAddTarefa.Execute(tarefa);
            if (response != null)
                return Ok(response);
            else
                return BadRequest();

        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, UpdateTarefaRequest tarefa)
        {
            var tarefaBanco = _useCaseGetTarefa.Execute(id);

            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            var response = _useCaseUpdateTarefa.Execute(tarefa, id);
            if (response != null)
                return Ok(response);
            else
                return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var response = _useCaseDeleteTarefa.Execute(id);

            if (response)
                return NoContent();
            else
                return NotFound();
        }
    }
}
