using ApiForReactNative.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiForReactNative.Domain.Entities;

public sealed class TableIki:Entity
{
    // İD DEĞERİ ENTİTY DEN  GUİD Gelecek

    public string AciklamaListesi {  get; set; }
    public string TeknisyenAd {  get; set; }
    public string DgtParcaKodu {  get; set; }
    public int StatusValue { get; set; }
    [NotMapped]
    public StatusEnum Status
    {
        get => StatusEnum.FromValue(StatusValue);
        set => StatusValue = value.Value;
    }
    public string OnayProjeYoneticisi {  get; set; } 
    public int KacAdetBeklemede { get; set; }
    public string Aciklama {  get; set; }
    public DateTime Tarih {  get; set; }

}
