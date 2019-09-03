namespace CheckIt.Common.DataProvider
{
    using Constants;

    public interface IDataProvider
    {
        string GetPath(string database = Constants.DB_NAME);
    }
}
