using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id   { get; set; }
        public string Name { get; set; }

        public int MyProperty { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department() 
        { 
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Department(int id, string name, int myProperty)
        {
            Id = id;
            Name = name;
            MyProperty = myProperty;
        }

        public void AddSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }

        public double TotalSalles (DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
