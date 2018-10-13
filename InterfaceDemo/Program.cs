using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // we can now have more than one type in this List
            List<IProductModel> cart = AddSampleData();  // instead of List<PhysicalProductModel>
            CustomerModel customer = GetCustomer();

            foreach(IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if(prod is IDigitalProductModel digital) // we could just use DigitalProductModelcs
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAMTimCorey T-Shirt " });
            output.Add(new PhysicalProductModel { Title = "Hard Drive " });

            // now we can add out Digital product too
            output.Add(new DigitalProductModelcs { Title = "Lesson Source Code" });

            // and other products
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish" });

            return output;

            // the big advantage with Interfaces is that we are not tied specifically to a certain type
            // if we were tied to a specific type (Physical, then we have to change a lot of our code if we want to have other product types
            // great for efficiency
        }
    }
}
