using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class EchoesOfValandis{
        
        private Player _player;
        private Parser _parser;
        private bool playing;

        public EchoesOfValandis(){
            playing = false;
            _parser = new Parser(new CommandWords());
            _player = new Player(CreateWorld());
        }
        public Room CreateWorld(){
            FarnsportCityZone Farnsport = new FarnsportCityZone();
            CavernZones ValandisCaverns = new CavernZones();
            FieldZones ValandisFields = new FieldZones();
            MountainZones ValandisMountains = new MountainZones();
            Farnsport.CreateZone();
            ValandisCaverns.CreateZone();
            ValandisFields.CreateZone();
            ValandisMountains.CreateZone();
            
            LenneHero lenne = new LenneHero();

            return Farnsport._rooms.ElementAt(0);

            
        }
        public void play(){
            bool finished = false;
            while(!finished){
                Console.Write("\n");
                Command command = _parser.ParseCommand(Console.ReadLine());
                if(command == null){
                    _player.ErrorMessage("I don't understand");

                }else{
                    finished = command.Execute(_player);
                }
            }
        }
        
        public void Start()
        {
            playing = true;
            _player.InfoMessage(Welcome());
        }

        public void End()
        {
            playing = false;
            _player.InfoMessage(Goodbye());
        }

        public string Welcome()
        {
            return "Welcome to Echoes Of Valandis\n\n - Here you can explore the world, battle monsters and interact with other characters\n\n - Type 'help' if you need help." + _player.CurrentRoom.Description();
        }

        public string Goodbye()
        {
            return "\nThank you for playing, Goodbye! \n";
        }
    }
}