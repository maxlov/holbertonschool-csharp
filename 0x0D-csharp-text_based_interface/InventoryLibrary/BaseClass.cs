using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryLibrary
{
    ///<summary>BaseClass for inventory management.</summary>
    public class BaseClass
    {
        ///<summary>ID to identify object.</summary>
        public string id { get; set;}

        ///<summary>Time object created.</summary>
        public DateTime date_created { get; set;}

        ///<summary>Time object updated.</summary>
        public DateTime date_updated { get; set;}

        ///<summary>BaseClass constructor.</summary>
        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.Now;
            date_updated = DateTime.Now;
        }

        /// <summary> Creates a string representation of BaseClass </summary>
        /// <returns> Returns string representation of BaseClass </returns>
        public override string ToString()
        {
            return $"{this.GetType().Name}.{this.id}\nCreated:{this.date_created}, Updated:{this.date_updated}";
        }
    }
}
