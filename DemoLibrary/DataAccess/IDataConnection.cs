using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess;

public interface IDataConnection
{
    IEnumerable<T> LoadData<T, U>(string storedProcedure, U parameters);
    int SaveData<T>(string storedProcedure, T data);
}
