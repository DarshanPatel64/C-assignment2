using System;
using System.Collections.Generic;

namespace demos{
    class InventoryList<T> where T : Product{
        private List<T> inventory;
        public InventoryList(){
            this.inventory = new List<T>();
        }
        public void Add(T item){ 
            inventory.Add(item);
        }
        public int getCount(){
            return this.inventory.Count;
        }
        public Product findByName(string name){

            foreach(var item in this.inventory){
                if(item._name == name){
                    return item;
                }
            }
            return new Product();
        }
        public List<Product> findByType(string type){
            var temp = new List<Product>();
            foreach(var item in this.inventory){
                if(item._type == type){
                    temp.Add(item);
                }
            }
            return temp;
        }
        public void remove(string name){
            foreach(var item in inventory.ToList()){
                if(item._name == name){
                    try{
                        inventory.Remove(item);
                    }catch(Exception ){

                    }
                }
            }
            Console.WriteLine("{0} removed, Number of Available Products : {1}",name,this.inventory.Count);
        }

        public void addQuantity(string name,int quantity){
            foreach(var item in inventory){
                if(item._name == name){
                    Console.WriteLine($"{name}\'s Current Quantity {item._quantity}");
                    item._quantity += quantity;
                    Console.WriteLine($"{item._name}'s updated quantity (+){quantity} : {item._quantity}");
                }
            }
        }
        public void calculateBill(){
            double bill = 0.0;
            var items = new Dictionary<string,int>();
            int count = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < count; i++){
                Console.WriteLine("enter product name");
                string product = Console.ReadLine();
                Console.WriteLine("enter product quantity");
                int quantity = int.Parse(Console.ReadLine());
                items[product] = quantity;
            }
            
            foreach(var item in items) {
                var x = this.findByName(item.Key);
                bill += (x._price*item.Value);
            }
            Console.WriteLine("Amount: " + bill);
        }
    }
}