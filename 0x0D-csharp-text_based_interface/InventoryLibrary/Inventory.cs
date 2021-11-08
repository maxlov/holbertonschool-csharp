using System;
using System.Collections.Generic;
using InventoryLibrary;


namespace InventoryLibrary
{
    ///<summary>Inventory class for inventory management.</summary>
    public class Inventory : BaseClass
    {
        ///<summary>User id of Inventory.</summary>
        public string user_id { get; set;}

        ///<summary>Item id of Inventory.</summary>
        public string item_id { get; set;}

        /// <summary>Quanitity of item in inventory</summary>
        public int quantity { get; set;}

        /// <summary> Inventory constructor</summary>
        /// <param name="user">User to get id from</param>
        /// <param name="item">Item to get id from</param>
        /// <param name="quantity">Number of items</param>
        public Inventory(User user, Item item, int quantity)
        {
            this.user_id = user.id;
            this.item_id = item.id;
            this.quantity = quantity;
        }

        /// <summary> Creates a string representation of Inventory </summary>
        /// <returns> Returns string representation of Inventory </returns>
        public override string ToString()
        {
            return $"{this.GetType().Name}.{this.id}\nUser.{this.user_id}, Item.{this.item_id}";
        }
    }
}
