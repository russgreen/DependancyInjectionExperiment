namespace DemoLibrary.DataAccess;

internal class SQLConnection : IDataConnection
{
    private readonly string _cnnString;

    public SQLConnection(string cnnString)
    {
        _cnnString = cnnString;
    }

    public IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters)
    {
        throw new NotImplementedException();
    }

    public int SaveData<T>(string storedProcedure, T data)
    {
        throw new NotImplementedException();
    }
}
