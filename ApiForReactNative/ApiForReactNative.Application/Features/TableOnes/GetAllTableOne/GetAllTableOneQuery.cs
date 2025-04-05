using ApiForReactNative.Domain.Entities;
using MediatR;
namespace ApiForReactNative.Application.Features.TableOne.GetAllTableOne;

public sealed record GetAllTableOneQuery() : IRequest<List<TableBir>>;