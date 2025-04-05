using Ardalis.SmartEnum;
public sealed class StatusEnum : SmartEnum<StatusEnum>
{
    public static readonly StatusEnum Beklemede = new("Beklemede", 1);
    public static readonly StatusEnum Kapali = new("Kapali", 2);
    public static readonly StatusEnum Aktif = new("Aktif", 3);
    public StatusEnum(string name, int value) : base(name, value)
    {
    }
}