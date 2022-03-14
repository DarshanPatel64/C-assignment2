using System;
namespace demos
{
    public class Program{

        static void Main(string[] args){
            var inventory = new InventoryList<Product>();
            inventory.Add(new Product("lettuce", 10.5 , 50 , "Leafy green"));
            inventory.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            System.Console.WriteLine(inventory.getCount());
        }
    
    }
}