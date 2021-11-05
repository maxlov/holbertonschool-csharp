using System;
using System.Collections.Generic;
using InventoryLibrary;


namespace InventoryLibrary
{
    ///<summary>User for inventory management.</summary>
    public class User : BaseClass
    {
        ///<summary>Name of User.</summary>
        public string name { get; set;}

        /// <summary> User constructor</summary>
        /// <param name="name"> Name of User </param>
        public User(string name)
        {
            this.name = name;
        }
    }
}
