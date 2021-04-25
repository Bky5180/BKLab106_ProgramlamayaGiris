namespace YeniiMetrobus.Interface
{
    public interface IMetrobusHatlari
    {
        hatlar Hatlar { get; set; }
    }

    public enum hatlar
    {
        AnaHat,
        BeslemeHat,
    }
}