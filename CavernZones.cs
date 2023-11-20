using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class CavernZones : WorldZone{
        public CavernZones() : base(){
            this.Zone = "Cavern";
            this._rooms = new List<Room>();
        }
        override
        public void CreateZone(){
            Room CavernsEntry = new Room("Valandis Caverns Entry Zone: Nothing present here");
            Room CavernsPylon = new Room("Valandis Caverns Teleport Pylon");
            Room CavernsNorth1 = new Room("Valandis Caverns North: Level 1");
            Room CavernsNorth2 = new Room("Valandis Caverns North: Boss: ");
            Room CavernsSouth = new Room("Valandis Caverns South: Enemies: 4 Cave Bats");
            Room CavernsEast = new Room("Valandis Caverns East: Enemies: 2 Skeleton Archers, 2 Armored Skeletons");
            Room CavernsWest = new Room("Valandis Caverns West: Enemies: 1 Cave bat, 2 Skeleton Archers, 1 Armored Skeleton");

            CavernsEntry.SetExit("North", CavernsNorth1);
            CavernsEntry.SetExit("South", CavernsSouth);
            CavernsEntry.SetExit("East", CavernsEast);
            CavernsEntry.SetExit("West", CavernsWest);
            CavernsEntry.SetExit("CavernPylon", CavernsPylon);

            CavernsNorth1.SetExit("North", CavernsNorth2);
            CavernsNorth1.SetExit("South", CavernsEntry);
            CavernsNorth2.SetExit("South", CavernsNorth1);

            CavernsSouth.SetExit("North", CavernsEntry);
            
            CavernsEast.SetExit("West", CavernsEntry);

            CavernsWest.SetExit("East", CavernsEntry);

            CavernsPylon.SetExit("South", CavernsEntry);

            _rooms.Add(CavernsEntry);
            _rooms.Add(CavernsPylon);
            _rooms.Add(CavernsNorth1);
            _rooms.Add(CavernsNorth2);
            _rooms.Add(CavernsSouth);
            _rooms.Add(CavernsEast);
            _rooms.Add(CavernsWest);
        }
    }
}