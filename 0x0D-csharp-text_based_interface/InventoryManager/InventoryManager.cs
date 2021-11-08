using System;
using InventoryLibrary;

namespace InventoryManager
{
    class InventoryManager
    {

        /// <summary>
        /// Main inventory manager loop.
        /// </summary>
        static void Main()
        {
            int status = 1;
            JSONStorage storage = new JSONStorage();
            InventoryManagerMessages messages = new InventoryManagerMessages();
            InventoryCommands commands = new InventoryCommands();
            storage.Load();

            while (true)
            {
                if (status == 1)
                    messages.Prompt();
                string[] command = Console.ReadLine().Split(' ');
                switch (command[0].ToLower())
                {
                    case "classnames":
                        commands.ClassNames();
                        break;
                    case "all":
                        status = commands.All(storage, command);
                        break;
                    /*case "create":
                        status = commands.Create(storage, command);
                        break;*/
                    case "show":
                        status = commands.Show(storage, command);
                        break;
                    /*case "update":
                        status = commands.Update(storage, command);
                        break;*/
                    case "delete":
                        status = commands.Delete(storage, command);
                        break;
                    case "exit":
                        storage.Save();
                        Console.WriteLine("Inventory saved. Now exiting, goodbye.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"Command <{command[0]}> could not be found.");
                        status = 0;
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
