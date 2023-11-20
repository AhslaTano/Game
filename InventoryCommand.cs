using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class InventoryCommand : Command{
        public InventoryCommand() : base() { 
            this.Name = "inventory";
        }


        override
        public bool Execute(User user)
        {
            if (Parameter != "")
            {
                user.Inventory(Parameter);
            }
            else
            {
                Console.WriteLine("What do you want to inventory?");
            }
            return true;
        }
    }
}