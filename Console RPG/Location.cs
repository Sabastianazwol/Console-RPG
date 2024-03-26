using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Console_RPG
{
    class Location
    {

        public static Location Xboxhq = new Location("Xboxhq", "the green gates with the xbox logo are on top of the bluding are big building ");
        public static Location pshq = new Location("pshq", "the bule gates  ps logo are on top of the bluding are big building ");
        public static Location lostHome = new Location("lostHome ", "a home that got lost and noone can find it ");
        public static Location spidermanhome = new Location("spidermanhome", "fights in space saves lives with aunt may has art in his room");
        public static Location dustydeop = new Location("dustydeop", "og landing spot always sweety");
       
  

        public string name;
        public string description;
        public battle battle;
        public POI interaction;
        public Location north, east, south, west;
        public Location(string name, string description, battle battle = null)
        {
            this.name = name;
            this.description = description;
            this.battle = battle;
        }
        public void SetNearByLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {


            if (!(north is null))
            {
                this.north = north;
                north.south = this;

            }

            if (!(east is null))
            {
                this.east = east;
                east.west = this;
            }

            if (!(south is null))
            {
                this.south = south;
                south.north = this;
            }

            if (!(west is null))
            {
                this.west = west;
                west.east = this;
            }

        }

        public void Resolve()
        {
            Console.WriteLine("You enter " + this.name + ".");
            Console.WriteLine(this.description);




            if (!(north is null))
                Console.WriteLine("north " + this.north.name);

            if (!(north is null))
                Console.WriteLine("east " + this.east.name);

            if (!(north is null))
                Console.WriteLine("south " + this.south.name);

            if (!(north is null))
                Console.WriteLine("west " + this.west.name);

            string direction = Console.ReadLine();
            Location nextLocaltion = null;

            if (direction == "north")
                nextLocaltion = this.north;
            else if (direction == "east")
                nextLocaltion = this.east;
            else if (direction == "south")
                nextLocaltion = this.south;
            else if (direction == "west")
                nextLocaltion = this.west;

            nextLocaltion.Resolve();
        }
    }
}
