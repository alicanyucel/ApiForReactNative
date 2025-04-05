using ApiForReactNative.Domain.Abstractions;

namespace ApiForReactNative.Domain.Entities;

public class TableOne:Entity // GUID ID GELECEK
{
    public string ProjeSorumlusu {  get; set; }
    public string ProjeAdi { get; set; }
    public string DGTParcaKodu {  get; set; }
    public string SorumluKisi {  get; set; }
    public string SeriNo {  get; set; }
    public int UrerimAdeti {  get; set; }
    public int Gun {  get; set; }
    public DateTime Tarih {  get; set; }
    public byte[] DosyaYukle { get; set; } // dosyalar yükleencek
    public string Aciklama {  get; set; }
    public bool Kaydet {  get; set; }= false; // default false
    public DateTime TeknisyebDosyaAcilmaZamani { get; set; }
}
