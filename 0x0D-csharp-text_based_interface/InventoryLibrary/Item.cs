using System;
using System.Collections.Generic;
using InventoryLibrary;


namespace InventoryLibrary
{
    ///<summary>Item for inventory management.</summary>
    public class Item : BaseClass
    {
        ///<summary>Name of item.</summary>
        public string name { get; set;}

        ///<summary>Description of item.</summary>
        public string description { get; set;}

        ///<summary>Price of item.</summary>
        public float price { get; set;}

        ///<summary>List of tags.</summary>
        public List<string> tags { get; set;}

        /// <summary> Item constructor</summary>
        /// <param name="name"> Name of item </param>
        /// <param name="description"> Desc of item (optional)</param>
        /// <param name="price"> Price of item (optional)</param>
        /// <param name="tags"> Tags of item (optional)</param>
        public Item(string name, string description = null, float price = 0.00f, List<string> tags = null)
        {
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round((double)price, 2);
            this.tags = tags;
        }

        /// <summary> Creates a string representation of Item </summary>
        /// <returns> Returns string representation of Items </returns>
        public override string ToString()
        {
            string item_repr = $"{this.GetType().Name}.{this.id}, Name: {this.name}";
            if (description != null)
                item_repr += $"\n{this.description}";
            if (price > 0)
                item_repr += $"\nPrice: ${this.price}";
            if (description != null)
                foreach(string tag in tags)
                    item_repr += tag + ',';
            return item_repr;
        }
    }
}
