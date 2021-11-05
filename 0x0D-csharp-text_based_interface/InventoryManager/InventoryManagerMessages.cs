using System;
using InventoryLibrary;

namespace InventoryManager
{
    /// <summary>
    /// Hold methods for system messages
    /// </summary>
    public class InventoryManagerMessages
    {
        /// <summary>
        /// Prints prompt message
        /// </summary>
        public void Prompt()
        {
            string prompt = @"Inventory Manager
-------------------------
<ClassNames> show all ClassNames of objects
<All> show all objects
<All [ClassName]> show all objects of a ClassName
<Create [ClassName]> a new object
<Show [ClassName object_id]> an object
<Update [ClassName object_id]> an object
<Delete [ClassName object_id]> an object
<Exit>";
            Console.WriteLine(prompt);
        }

        /// <summary>
        /// Prints messae for Class error.
        /// </summary>
        /// <param name="classname">Invalid classname</param>
        /// <returns>Returns 0</returns>
        public int InvalidClassError(string classname)
        {
            Console.WriteLine($"{classname} is not a valid object type");
            return (0);
        }

        /// <summary>
        /// Prints message for ID error.
        /// </summary>
        /// <param name="id">Invalid ID</param>
        /// <returns>Returns 0</returns>
        public int InvalidIDError(string id)
        {
            Console.WriteLine($"Object {id} could not be found");
            return (0);
        }
    }
}
