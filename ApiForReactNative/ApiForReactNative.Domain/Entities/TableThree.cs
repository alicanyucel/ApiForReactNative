using ApiForReactNative.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiForReactNative.Domain.Entities;

public class TableThree:Entity // GUİD ID
{
    public string UygunsuzlukTespitListesi {  get; set; }
    public string TeknisyenAd {  get; set; }
    public string DGTParcaKodu {  get; set; }
    public int StatusValue { get; set; }
    [NotMapped]
    public StatusEnum Status
    {
        get => StatusEnum.FromValue(StatusValue);
        set => StatusValue = value.Value;
    }
    public int KacAdetBeklemede {  get; set; }
    public string AciklamaKalitecidenGelecek {  get; set; }
    public DateTime Tarih {  get; set; }
}
