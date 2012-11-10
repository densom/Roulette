namespace Roulette.Formatters
{
    interface IResultFormatter
    {
        string GetHeader();
        string GetDetail(ResultDataItem item);
    }
}