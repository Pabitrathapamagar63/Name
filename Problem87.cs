using System;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
namespace ConsoleApp
{
    public class Product
    {
        public int Pid;
        public string Pname;
        public int Price;

        public Product(int pid, string pname, int price)
        {
            Pid = pid;
            Pname = pname;
            Price = price;
        }

        public void PInfo()
        {
            Console.WriteLine($"Pid:{Pid}, Pname:{Pname}, Price: {Price}");
        }

    }

    public class Order
    {
        public String OrderDate;
        public int TotalAmount;

        public Product[] Products;

        public Order(String orderdate, int totalamount, Product[] products)
        {
            OrderDate = orderdate;
            TotalAmount = totalamount;
            Products = products;

        }

        public void OrderInfo()
        {
            Console.WriteLine($"Order:{OrderDate}, TotalAmount:{TotalAmount}");
            Console.WriteLine("Products:");
            foreach (var product in Products)
            {
                product.PInfo();
            }
        }
    }

    public class Customer
    {
        public int CustomerId;
        public double PhoneNum;
        public string Location;
        public Order[] Orders;
        public Customer(int customerid, double phonenum, string location, Order[] orders)
        {
            CustomerId = customerid;
            PhoneNum = phonenum;
            Location = location;
            Orders = orders;
        }

        public void CInfo()
        {
            Console.WriteLine($"CustomerId:{CustomerId}, PhoneNum:{PhoneNum}, Location:{Location}");
            Console.WriteLine("Order:");
            foreach (var Order in Orders)
            {
                Order.OrderInfo();
            }
        }
    }


    public class Problem87
    {
        public static void solution()
        {
            Product obj = new Product(1, "Anything", 50000);
            Product obj9 = new Product(2, "Something", 60000);
            Product obj8 = new Product(3, "Nothing", 8000);

            Product[] products22 = new Product[] { obj, obj9, obj8 };


            Order obj3 = new Order("2024 - 02 - 13", 50090, products22);

            Order[] orders66 = new Order[] { obj3 };

            Customer obj55 = new Customer(3, 9869742081, "jyamira", orders66);
            obj55.CInfo();
        }
    }

}