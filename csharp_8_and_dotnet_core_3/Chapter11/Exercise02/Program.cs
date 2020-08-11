using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            // using (StreamWriter writer = new StreamWriter("Northwind.xml"))
            using (TextWriter writer = new StreamWriter("Northwind.xml"))
            using (Northwind db = new Northwind())
            {
                DbSet<Category> categories = db.Categories;
                var xmlSerializer = new XmlSerializer(typeof(DbSet<Category>));
                xmlSerializer.Serialize(writer, categories);
                // WriteLine($"{writer.ToString()}");

                DbSet<Product> products = db.Products;
                xmlSerializer = new XmlSerializer(typeof(DbSet<Product>));
                xmlSerializer.Serialize(writer, products);
                // WriteLine($"{writer.ToString()}");
            }
        }
    }
}
