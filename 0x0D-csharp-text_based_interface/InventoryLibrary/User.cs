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

        /// <summary> Creates a string representation of User </summary>
        /// <returns> Returns string representation of User </returns>
        public override string ToString()
        {
            return $"{this.GetType().Name}.{this.id}, Name: {this.name}";
        }
    }
}
