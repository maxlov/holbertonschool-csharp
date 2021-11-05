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


    }
}
