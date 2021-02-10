using System;

namespace oop-6214421017-w05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Room r01 = new Room("434", "Computer Lab", 8, 8, "standard");
            Console.WriteLine(r01.roomAddress() + r01.createBuilding("12.6632196","102.10375").buildingLatLong());*/
            string[] arrayRoom = { "434", "425", "429" };
            string[] arrayLat_Long = { "12.6632196", "102.10375" };
            string[] arrayRoomName = { "Computer Lab", "Computer Lecture", "Teacher Office" };
            for (int i = 0; i <= 2; i++)
            {
                Room r01 = new Room(arrayRoom[i], arrayRoomName[i], 8, 8, "Standard");
                Console.WriteLine(r01.roomAddress() + r01.createBuilding(arrayLat_Long[0], arrayLat_Long[1]).buildingLatLong());
            }
               
                
                Student s = new Student(1,new Curriculumn("Information Technology","Bachelor Degree"));
                
                Console.WriteLine(s.ToString());
            

        }
    }
}
