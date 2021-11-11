using System;
using InventoryLibrary;
using InventoryManager;
using System.Collections.Generic;

namespace InventoryManager
{

    /// <summary>
    /// Class containing commands for InventoryManager
    /// </summary>
    class InventoryCommands
    {
        string[] classList = {"BaseClass", "Item", "User", "Inventory"};
        InventoryManagerMessages messages = new InventoryManagerMessages();

        /// <summary>
        /// Prints all classnames
        /// </summary>
        public void ClassNames()
        {
            Console.WriteLine("Available classes:");
            foreach (string className in classList)
                Console.WriteLine(className);
            Console.WriteLine();
        }

        /// <summary>
        /// Prints out each object
        /// </summary>
        /// <param name="storage">Object storage</param>
        /// <param name="command">User command</param>
        /// <returns>1 on success else 0</returns>
        public int All(JSONStorage storage, string[] command)
        {
            if (command.Length > 1)
            {
                if (!ValidClassname(command[1]))
                    return (0);
                foreach(var item in storage.All(command[1]))
                    Console.WriteLine(item.Value);
                return (1);
            }

            foreach(var item in storage.All())
                    Console.WriteLine(item.Value);
            return (1);
        }

        public int Create(JSONStorage storage, string[] command)
        {
            if (!ValidClassname(command[1]))
                return (0);

            switch (command[1])
            {
                case "BaseClass":
                    Console.WriteLine("Creating new BaseClass...");
                    BaseClass baseClass = new BaseClass();
                    Console.WriteLine(baseClass);
                    storage.New(baseClass);
                    break;
                case "User":
                    Console.WriteLine("Creating new User...");
                    Console.WriteLine("Enter a username.");
                    string username = Console.ReadLine();
                    User user = new User(username);
                    Console.WriteLine(user);
                    storage.New(user);
                    break;
                case "Item":
                    Console.WriteLine("Creating new Item...");
                    Console.WriteLine("Enter a name for the item.");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a description for the item.");
                    Console.WriteLine("If you wouldn't like a description, just hit enter");
                    string description = Console.ReadLine();
                    if (description == "")
                        description = null;
                    Console.WriteLine("Enter a price for the item.");
                    Console.WriteLine("If you wouldn't like a price, just hit enter and it will be set to 0.00");
                    string priceString = Console.ReadLine();
                    float price;
                    if (priceString == "")
                        price = 0.00f;
                    else
                        price = float.Parse(priceString); 
                    Console.WriteLine("Enter a tags for the item on one line seperated by spaces.");
                    Console.WriteLine("If you wouldn't like tags, just hit enter");
                    string tagString = Console.ReadLine();
                    List<string> tags = new List<string>();
                    if (tagString == "")
                        tags = null;
                    else
                        foreach(string tag in tagString.Split(' '))
                            tags.Add(tag);
                    Console.WriteLine("Instantiating new Item...");
                    Item item = new Item(name, description, price, tags);
                    Console.WriteLine(item);
                    storage.New(item);
                    break;
                case "Inventory":
                    Console.WriteLine("Creating new Inventory...");
                    Console.WriteLine("Enter id of item:");
                    string itemID = Console.ReadLine();
                    Item invItem;
                    if (ValidateKey(storage, "Item." + itemID))
                    {
                        invItem = (Item)storage.objects["Item." + itemID];
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                        return (0);
                    }
                    Console.WriteLine("Enter id of user:");
                    string userID = Console.ReadLine();
                    User invUser;
                    if (ValidateKey(storage, "User." + userID))
                    {
                        invUser = (User)storage.objects["User." + userID];
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
                        return (0);
                    }
                    Console.WriteLine("Enter quantity of item:");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Instantiating inventory");
                    Inventory inventory = new Inventory(invUser, invItem, quantity);
                    Console.WriteLine(inventory);
                    storage.New(inventory);
                    break;
                default:
                    break;
            }
            storage.Save();
            return (1);
        }

        /// <summary>
        /// Prints out a specific object.
        /// </summary>
        /// <param name="storage">Active storage object</param>
        /// <param name="command">Inputed command</param>
        /// <returns>Returns 1 on success else 0</returns>
        public int Show(JSONStorage storage, string[] command)
        {
            if (!ValidateInput(storage, command))
                return (0);

            string key = $"{command[1]}.{command[2]}";
            Console.WriteLine(storage.objects[key].ToString());

            return (1);
        }

        /// <summary>
        /// Deletes object based on classname and id
        /// </summary>
        /// <param name="storage">Reference to object storage</param>
        /// <param name="command">User's command</param>
        /// <returns>1 on success 0 on failure</returns>
        public int Delete(JSONStorage storage, string[] command)
        {
            if (!ValidateInput(storage, command))
                return (0);
            
            string key = $"{command[1]}.{command[2]}";

            Console.WriteLine($"Deleting {key}...");
            Console.WriteLine(storage.objects[key].ToString());
            storage.objects.Remove(key);
            storage.Save();
            return (1);
        }

        /// <summary>
        /// A check to determine if a classname is valid.
        /// </summary>
        /// <param name="classname">Classname being tested</param>
        /// <returns>True if valid else false</returns>
        public bool ValidClassname(string classname)
        {
            foreach(string name in classList)
                if (classname == name)
                    return true;
            return false;
        }

        /// <summary>
        /// Ensures input is valid for a create or update or delete call
        /// </summary>
        /// <param name="storage">Storage device that contains objects</param>
        /// <param name="command">User's command</param>
        /// <returns></returns>
        public bool ValidateInput(JSONStorage storage, string[] command)
        {
            if (!ValidClassname(command[1]))
            {
                messages.InvalidClassError(command[1]);
                return false;
            }

            string key = $"{command[1]}.{command[2]}";
            
            return ValidateKey(storage, key);
        }

        /// <summary>
        /// Checks if key is in storage
        /// </summary>
        /// /// <param name="storage">Storage device that contains objects</param>
        /// <param name="key">Key that is being checked</param>
        /// <returns>True if its there otherwise false</returns>
        public bool ValidateKey(JSONStorage storage, string key)
        {
            if (!storage.objects.ContainsKey(key))
            {
                messages.InvalidIDError(key);
                return false;
            }
            return true;
        }
    }
}
