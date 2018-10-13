using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IDigitalProductModel : IProductModel // what we are doing here is we are adding all stuff from IProductModel to this contract
    {
        int TotalDownloadsLeft { get; }
    }
}
