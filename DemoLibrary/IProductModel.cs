using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // the interface is a contract, who ever implements that contract will have what ever the contract says they will have
    // other items can use that contract as the variable type, and that variable will be able to directly access anything that the contract specifies, but nothing outside
    // the other option is INHERITANCE 

    public interface IProductModel
    {
        // property signiture
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }

        // method signiture
        void ShipItem(CustomerModel customer);
    }
}
