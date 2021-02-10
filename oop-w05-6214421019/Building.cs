using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421019-w05
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLat;
        private string buildingLong;
        private Room[] rooms = new Room[20];
        public Building() { }
        public Building(string blt, string bll) { this.BuildingLat = blt; this.BuildingLong = bll; }
        public Building(string bc,string bn,string blt,string bll)
        {
            this.BuildingCode = bc;
            this.BuildingName = bn;
            this.BuildingLat = blt;
            this.BuildingLong = bll;
        }

        public string BuildingCode { get => buildingCode; set => buildingCode = value; }
        public string BuildingName { get => buildingName; set => buildingName = value; }
        public string BuildingLat { get => buildingLat; set => buildingLat = value; }
        public string BuildingLong { get => buildingLong; set => buildingLong = value; }
        internal Room[] Rooms { get => rooms; set => rooms = value; }
        public void setRooms(int index,Room room)
        {

            this.rooms[index] = room;
        }
        /*public Room getRoom()
        {
            return ;
        }*/

        public string buildingLatLong()
        {
            return this.BuildingLat + " , " + this.BuildingLong;
        }

    }
}
