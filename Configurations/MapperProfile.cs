using System.Text.RegularExpressions;
using AutoMapper;
using TrilhaApiDesafio.DTO;
using TrilhaApiDesafio.Models;
using TrilhaApiDesafio.UseCase;

namespace TrilhaApiDesafio.Configurations
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            //Client
            CreateMap<AddTarefaRequest, Tarefa >().ReverseMap();

            CreateMap<AddTarefaResponse, Tarefa>().ReverseMap();

            CreateMap<UpdateTarefaRequest, Tarefa>().ReverseMap();

            CreateMap<UpdateTarefaResponse, Tarefa>().ReverseMap();

            CreateMap<GetTarefaResponse, Tarefa > ().ReverseMap();
            /*
            //Group
            CreateMap<Group, GroupViewModel>().ReverseMap()
                .ForMember(dest => dest.Description, src => src.Ignore())
                .AfterMap((src, dest) =>
                {
                    dest.CreatedAt = DateTime.Now;
                    dest.Description = dest.Name;
                });*/

        }
    }
}
