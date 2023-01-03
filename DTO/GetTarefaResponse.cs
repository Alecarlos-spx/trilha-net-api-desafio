using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.DTO
{
    public class GetTarefaResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}
