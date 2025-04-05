using MediatR;
using TS.Result;

namespace ApiForReactNative.Application.Features.TableOne.CreateTableOnes;

public sealed record TableOneCreateCommand(
        string ProjeSorumlusu,string DGTParcaKodu,string SorumluKisi,string SeriNo,int UretimAdeti,int Gun,DateTime Tarih, byte[] DosyaYukle,
        string Aciklama,bool Kaydet,DateTime TeknisyenDosyaAcilmaZamani
       ) : IRequest<Result<string>>;
