using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w05
{
    class Room
    {
        private string roomCode;
        private string roomName;
        private int roomWidth;
        private int roomLength;
        private string roomType;
        private Building building;

        public string RoomCode { get => roomCode; set => roomCode = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public int RoomWidth { get => roomWidth; set => roomWidth = value; }
        public int RoomLength { get => roomLength; set => roomLength = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        internal Building Building { get => building; set => building = value; }

        public Room() { }
        public Room(string rc,string rn,int rw,int rl,string rt)
        {
            this.RoomCode = rc;
            this.RoomName = rn;
            this.RoomWidth = rw;
            this.RoomLength = rl;
            this.RoomType = rt;
        }
        public void setBuilding(Building b)
        {
            this.Building = b;
        }
        public Building getbuildingg()
        {
            return this.Building;
        }
        
        public int roomArea(int rw,int rl)
        {
            return rw * rl;
        }
        public int roomAvailable(int rw,int rl)
        {
            int arc = 2;
            return (rw * rl) / arc;
        }
        public Building createBuilding(string blt,string bll)
        {
            return new Building(blt, bll);
        }
        
        public string roomAddress()
        {
            return "RoomCode: " + this.RoomCode + " RoomName: " + this.RoomName + " RoomArea: " + roomArea(this.RoomWidth, this.RoomLength) + " RoomAvailable:" + roomAvailable(this.RoomWidth, this.RoomLength) + " RoomLat&RoomLong:";
               
        }
        public int getArea()
        {
            return this.roomLength * this.roomWidth;
        }
        public int allowAmount(int peoplePer2meter)
        {
            return (int)this.getArea() / peoplePer2meter;
        }
    }
}
