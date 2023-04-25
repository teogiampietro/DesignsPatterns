using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.FactoryPattern2
{
    public interface IFileValidator
    {
        string[] GetData();
        bool ContainsData();
        bool CanBeOpened();
        bool CheckNullorWithSpace();
        bool Sctructure();
    }
}
