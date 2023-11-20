using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class Parser{

        private CommandWords _commands;

        public Parser() : this(new CommandWords()){}

        public Parser(CommandWords newCommands){
            _commands = newCommands;
        }
        public Command ParseCommand(string CommandString){
            Command command = null;
            string[] words = CommandString.Split(' ');
            if(words.Length > 0){
                command = _commands.Get(words[0]);
                if(command != null){
                    if(words.Length > 1){
                        command.SecondWord = words[1];
                    }else{
                        command.SecondWord = null;
                    }
                }else{
                    // This is debug line of code, should remove for regular execution
                    Console.WriteLine(">>>Did not find the command " + words[0]);
                }
            }else{
                // This is a debug line of code
                Console.WriteLine("No words parsed!");
            }
            return command;
        }
        public string Description(){
            return _commands.Description();
        }
    }
}