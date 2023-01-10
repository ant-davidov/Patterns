using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.AsyncFactories
{
    internal interface IAsyncInit<T>
    {
        Task<T> InitAsync();
    }
}
