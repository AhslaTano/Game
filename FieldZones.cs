using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class FieldZones : WorldZone{
        public FieldZones() : base(){
            this.Zone = "Fields";
            this._rooms = new List<Room>();
        }
        override
        public void CreateZone(){
            Room FieldsEntry = new Room("Valandis Fields Entry Zone: Nothing present here");
            Room FieldsPylon = new Room("Valandis Fields Teleport Pylon");
            Room FieldsNorth1 = new Room("Valandis Fields North: Level 1: Enemies: 2 Vortexians, 1 Nebula Floater, 2 Drakanians, 1 Stargazer");
            Room VortexPillar = new Room("Vortex Pillar: Enemies: Vortex Pillar, 2 Vortexians, 2 Storm Divers");
            Room NebulaPillar = new Room("Nebula Pillar: Enemies: Nebula Pillar, 2 Nebula Floaters, 2 Predictors");
            Room StardustPillar = new Room("Stardust Pillar: Enemies: Stardust Pillar, 2 Stargazers, 2 Flow Invaders");
            Room SolarPillar = new Room("Solar Pillar: Enemies: Solar Pillar, 2 Drakanians, 2 Drakomire Riders");
            Room FieldsNorth2 = new Room("Valandis Fields North: Final Boss: Moon Lord");
            Room FieldsSouth1 = new Room("Valandis Fields South: Level 1");
            Room FieldsSouth2 = new Room("Valandis Fields South: Boss: ");
            Room FieldsEast = new Room("Valandis Fields East: Enemies: 2 Blue Slimes, 2 Green Slimes");
            Room FieldsWest = new Room("Valandis Fields West: Enemies: 1 Green Slime, 2 Blue Slimes, 1 Purple Slime");

            FieldsEntry.SetExit("South", FieldsSouth1);
            FieldsEntry.SetExit("East", FieldsEast);
            FieldsEntry.SetExit("West", FieldsWest);
            FieldsEntry.SetExit("FieldPylon", FieldsPylon);

            //Final Boss Fight: Moon Lord Progression
            FieldsEntry.SetExit("North", FieldsNorth1);
            FieldsNorth1.SetExit("North", VortexPillar);
            FieldsNorth1.SetExit("South", NebulaPillar);
            FieldsNorth1.SetExit("East", StardustPillar);
            FieldsNorth1.SetExit("West", SolarPillar);
            VortexPillar.SetExit("North", FieldsNorth2);
            NebulaPillar.SetExit("North", FieldsNorth2);
            StardustPillar.SetExit("West", FieldsNorth2);
            SolarPillar.SetExit("East", FieldsNorth2);
            FieldsNorth2.SetExit("South", FieldsEntry);

            FieldsNorth1.SetExit("South", FieldsEntry);

            FieldsSouth1.SetExit("North", FieldsEntry);
            FieldsSouth1.SetExit("South", FieldsSouth2);
            FieldsSouth2.SetExit("North", FieldsSouth1);

            FieldsEast.SetExit("West", FieldsEntry);
            
            FieldsWest.SetExit("East", FieldsEntry);

            FieldsPylon.SetExit("FieldEntry", FieldsEntry);

            _rooms.Add(FieldsPylon);
            _rooms.Add(FieldsEntry);
            _rooms.Add(FieldsNorth1);
            _rooms.Add(FieldsNorth2);
            _rooms.Add(FieldsSouth1);
            _rooms.Add(FieldsSouth2);
            _rooms.Add(FieldsEast);
            _rooms.Add(FieldsWest);
            _rooms.Add(VortexPillar);
            _rooms.Add(NebulaPillar);
            _rooms.Add(StardustPillar);
            _rooms.Add(SolarPillar);
        }
    }
}