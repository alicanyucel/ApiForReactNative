
using ApiForReactNative.Application.Features.TableOne.CreateTableOnes;
using ApiForReactNative.Application.Features.TableTwo.CreateTabloTwo;
using ApiForReactNative.Application.Features.TabloThree.CreateTableThree;
using ApiForReactNative.Domain.Entities;
using AutoMapper;

namespace ApiForReactNative.Application.Mapping;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateTableThreeCommand, TableUc>().ReverseMap();
        CreateMap<TableOneCreateCommand, TableBir>().ReverseMap();
        CreateMap<CreateTableTwoCommand, TableIki>().ReverseMap();

    }
}
