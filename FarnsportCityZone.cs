using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class FarnsportCityZone : WorldZone{
        public FarnsportCityZone() : base(){
            this.Zone = "Farnsport City";
            this._rooms = new List<Room>();
        }
        override
        public void CreateZone(){
            Room FarnsportCityEntry = new Room("Entry for City of Farnsport");
            Room FarnsportSquare = new Room("Farnsport City Square");
            Room FarnsportNorth = new Room("North side of Farnsport");
            Room FarnsportSouth = new Room("South side of Farnsport");
            Room FarnsportEast = new Room("East side of Farnsport");
            Room FarnsportWest = new Room("West side of Farnsport");
            Room armorMerchant = new Room("Farnsport Armor Merchant");
            Room weaponsMerchant = new Room("Farnsport Weapons Merchant");
            Room generalgoodsMerchant = new Room("Farnsport General Goods Merchant");
            Room raresMerchant = new Room("Rares Merchant");
            Room potionsMerchant = new Room("Potions Merchant");
            Room FarnsportPylon = new Room("City of Farnsport Teleport Pylon");

            FarnsportCityEntry.SetExit("North", FarnsportSquare);
            FarnsportCityEntry.SetExit("FarnsportCityPylon", FarnsportPylon);
            FarnsportCityEntry.SetExit("South", FarnsportSouth);   

            FarnsportPylon.SetExit("FarnsportEntry", FarnsportCityEntry);

            FarnsportSquare.SetExit("North", FarnsportNorth);
            FarnsportSquare.SetExit("South", FarnsportCityEntry);
            FarnsportSquare.SetExit("East", FarnsportEast);
            FarnsportSquare.SetExit("West", FarnsportWest);

            FarnsportNorth.SetExit("East", generalgoodsMerchant);
            generalgoodsMerchant.SetExit("West", FarnsportNorth);
            FarnsportNorth.SetExit("West", raresMerchant);
            raresMerchant.SetExit("East", FarnsportNorth);
            FarnsportNorth.SetExit("South", FarnsportSquare);

            FarnsportSouth.SetExit("East", potionsMerchant);
            potionsMerchant.SetExit("West", FarnsportSouth);
            FarnsportSouth.SetExit("North", FarnsportCityEntry);

            FarnsportEast.SetExit("East", armorMerchant);
            armorMerchant.SetExit("West", FarnsportEast);
            FarnsportEast.SetExit("West", weaponsMerchant);
            weaponsMerchant.SetExit("East", FarnsportEast);
            FarnsportEast.SetExit("SquareWest", FarnsportSquare);

            FarnsportWest.SetExit("East", FarnsportSquare);
            
            _rooms.Add(FarnsportSquare);
            _rooms.Add(FarnsportNorth);
            _rooms.Add(FarnsportSouth);
            _rooms.Add(FarnsportEast);
            _rooms.Add(FarnsportWest);
            _rooms.Add(FarnsportCityEntry);
            _rooms.Add(armorMerchant);
            _rooms.Add(weaponsMerchant);
            _rooms.Add(generalgoodsMerchant);
            _rooms.Add(raresMerchant);
            _rooms.Add(potionsMerchant);
            _rooms.Add(FarnsportPylon);
        }
    }
}