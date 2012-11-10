namespace RouletteLogic.Formatters
{
    public interface IResultFormatter
    {
        string GetHeader();
        string GetDetail(ResultDataItem item);
    }
}