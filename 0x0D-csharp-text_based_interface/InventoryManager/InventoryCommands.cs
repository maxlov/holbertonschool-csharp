using System;
using InventoryLibrary;

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
                    Console.WriteLine(obj.Value);
                return (1);
            }

            foreach(var item in storage.All())
                    Console.WriteLine(obj.Value);
            return (1);
        }

        /// <summary>
        /// Prints out a specific object.
        /// </summary>
        /// <param name="storage">Active storage object</param>
        /// <param name="command">Inputted command</param>
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

        public bool ValidateInput(JSONStorage storage, string[] command)
        {
            if (!ValidClassname(command[1]))
            {
                messages.InvalidClassError(command[1]);
                return false;
            }

            string key = $"{command[1]}.{command[2]}";
            if (!storage.objects.ContainsKey(key))
            {
                messages.InvalidIDError(command[2]);
                return false;
            }
            return true;
        }
    }
}
