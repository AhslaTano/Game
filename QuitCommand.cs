using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class QuitCommand: Command{
        public QuitCommand() : base() { }
            this.name = "quit";

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