using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class CommandWords{
        
        private Dictionary<string, Command> _commands;

        private static Command[] _commandArray = { new QuitCommand(), new InventoryCommand()};

        public CommandWords() : this(_commandArray){}

        public CommandWords(Command[] CommandList){
            _commands = new Dictionary<string, Command>();
            foreach(Command command in CommandList){
                _commands[command.Name] = command;
                Command Help = new HelpCommand(this);
                _commands[Help.Name] = Help;
            }
        }
        public Command Get(string word){
            Command command = null;
            _commands.TryGetValue(word, out command);
            return command;
        }
        public string Description(){
            string commandNames = "";
            Dictionary<string, Command>.KeyCollection Keys = _commands.Keys;
            foreach(string commandName in Keys){
                commandNames += " " + commandName;
            }
            return commandNames;
        }
    }
}