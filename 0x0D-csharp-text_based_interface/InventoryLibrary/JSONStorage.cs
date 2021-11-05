using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using InventoryLibrary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    ///<summary>Inventory class for inventory management.</summary>
    public class JSONStorage
    {
        ///<summary>Path of file to store data.</summary>
        public string file_string { get; set;}

        ///<summary>Dictionary that holds objects.</summary>
        public Dictionary<string, object> objects { get; set;}

        /// <summary> JSONStorage constructor</summary>
        /// <param name="file_string">String that contains path of storage file</param>
        public JSONStorage(string file_string = @"./storage/inventory_manager.json")
        {
            this.file_string = file_string;
        }

        /// <summary>Returns objects dictionary.</summary>
        /// <param name="className">If specified, returns dict of classname</param>
        public Dictionary<string, object> All(string className = null)
        {
            if (className == null)
                return (objects);
            
            Dictionary<string, object> specificObjects = new Dictionary<string, object>();

            foreach(var item in objects)
                if (item.Key.Split('.')[0] == className)
                    specificObjects.Add(item.Key, item.Value);

            return specificObjects;
        }

        /// <summary>Adds new object to dictionary</summary>
        /// <param name="obj">Object to add to dictionary</param>
        public void New(BaseClass obj)
        {
            objects.Add($"{this.GetType().Name}.{obj.id}", obj);
        }

        /// <summary> Serializes objects to JSON and saves to the JSON file </summary>
        public void Save()
        {
            string objectsSerialized = JsonSerializer.Serialize(objects);
            File.WriteAllText(file_string, objectsSerialized);
        }

        /// <summary> Deserializes JSON file to objects</summary>
        public void Load()
        {
            string JsonText = File.ReadAllText(file_string);
            if (JsonText != string.Empty)
                objects = JsonSerializer.Deserialize<Dictionary<string, object>>(JsonText);
            else
                objects = new Dictionary<string, object>();
        }
    }
}
