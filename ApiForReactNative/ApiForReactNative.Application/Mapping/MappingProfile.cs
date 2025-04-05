using ApiForReactNative.Application.Features.TableOne.CreateTableOne;
using ApiForReactNative.Application.Features.TableTwo.CreateTabloTwo;
using ApiForReactNative.Application.Features.TabloThree.CreateTableThree;
using ApiForReactNative.Domain.Entities;
using AutoMapper;

namespace ApiForReactNative.Application.Mapping;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateTableThreeCommand, TableThree>().ReverseMap();
        CreateMap<CreateTableOneCommand, TableOne>().ReverseMap();
        CreateMap<CreateTableTwoCommand, TableTwo>().ReverseMap();

    }
}
