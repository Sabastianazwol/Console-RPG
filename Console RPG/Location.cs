using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {


        public string name;
        public string description;
        public Battle battle;

        public Location north, east, south, west;

        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;

            if (!(north is null))
                north.south = this;

            if (!(east is null))
                east.west = this;

            if (!(south is null))
                south.north = this;

            if (!(west is null))
                west.east = this;



        }

        public void Resolve()
        {
            Console.WriteLine("You find yourself in " + this.name + ".");
            Console.WriteLine(this.description);



            if (!(north is null))
                Console.WriteLine("North: " + this.north.name);


            if (!(east is null))
                Console.WriteLine("East: " + this.east.name);



            if (!(south is null))
                Console.WriteLine("South: " + this.south.name);



            if (!(west is null))
                Console.WriteLine("West: " + this.west.name);



            string direction = Console.ReadLine();
            Location nextLocation = null;

            // What happens if user dosen't give a proper input?

            if (direction == "north")
                nextLocation = this.north;

            if (direction == "east")
                nextLocation = this.east;

            if (direction == "south")
                nextLocation = this.south;

            if (direction == "west")
                nextLocation = this.west;


            nextLocation.Resolve();









        }

    }







}
