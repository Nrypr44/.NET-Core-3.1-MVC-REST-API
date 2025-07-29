using AutoMapper;
using project.DTOs;
using project.Models;

namespace project.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {  //kaynak = > hedef
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();

            CreateMap<Command, CommandReadDto>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}