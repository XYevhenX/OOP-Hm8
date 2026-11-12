using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    /*Порушено принцип єдиної відповідальності (Single Responsibility Principle). 
     *Клас Order має відповідати лише за дані замовлення, а не за збереження в 
     *базу даних чи вивід на екран.*/
    class Item
    {

    }
    /*class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {*//*...*//*}
        public void GetItems() {*//*...*//*}
        public void GetItemCount() {*//*...*//*}
        public void AddItem(Item item) {*//*...*//*}
        public void DeleteItem(Item item) {*//*...*//*}

        public void PrintOrder() {*//*...*//*}
        public void ShowOrder() {*//*...*//*}

        public void Load() {*//*...*//*}
        public void Save() {*//*...*//*}
        public void Update() {*//*...*//*}
        public void Delete() {*//*...*//*}
    }*/
    class Order
    {
        private List<Item> itemList = new List<Item>();

        public List<Item> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }

        public void CalculateTotalSum() { }
        public void GetItems() { }
        public void GetItemCount() { }
        public void AddItem(Item item) { }
        public void DeleteItem(Item item) { }
    }

    class OrderRepository
    {
        public void Load(Order order) { }
        public void Save(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }

    class OrderPrinter
    {
        public void PrintOrder(Order order) { }
        public void ShowOrder(Order order) { }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
