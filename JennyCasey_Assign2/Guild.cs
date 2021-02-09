/* CSCI473 
 * Assignment 2
 * DATE: 2/9/2021
 * TEAM: JennyCasey
 * Contributors: Jennifer Paul (z1878099) and Casey McDermott (z1878096)
 * PURPOSE: The purpose of this assignment is to emulate a game. The program will read in 
 *          input files of  players.txt, and guilds.txt. From there, there 
 *          will be 2 dictionaries made, one for the players, and one for the guilds. 
 *          From there, the user can make various actions in the form, such as creating a 
 *          new player, creating a new guild, disbanding a guild, searching for a guild/player
 *          and so on. 
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace JennyCasey_Assign2
{
    public enum Type { Casual, Questing, Mythic, Raiding, PVP };


    /**************************************************************************************************************************
     * Class - Guild
     * 
     * The player class is used store the information of each individual guild. 
     * 
     * - There are 3 private attributes that stores information about each individual guild, such as the guild ID, name, and
     *    server
     * - The huild class has an IComparable interface in order to sort the guild based on its name.
     * - Guild Class Methods: 
     *            BuildGuildDictionary => This method reads in the guild.txt file and then parses the information for each
     *                                    record into the class attributes, and then creates a new guild object, and adds
     *                                    that object to the guild dictionary.
     *            
     * ************************************************************************************************************************/
    class Guild : IComparable
    {
        private uint id;
        private string name;
        private string server;
        public Guild()
        {
            id = 0;
            name = "";
            server = "";
        }
        //alternate constructor
        public Guild(uint id, string name, string server)
        {
            this.id = id;
            this.name = name;
            this.server = server;
        }
        public uint ID
        {
            //free read/write acess so getter and setters
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            //free read/write acess so getter and setters
            get { return name; }
            set { name = value; }
        }
        public string Server
        {
            //free read/write acess so getter and setters
            get { return server; }
            set { server = value; }
        }
        
        //create a dictionary to store guild info
        public Dictionary<uint, Guild> BuildGuildDictionary()
        {
            string guildRecord;
            uint uintGuildId;
            var guilds = new Dictionary<uint, Guild>();
            using (StreamReader inFile = new StreamReader("../../guilds.txt"))
            {
                while ((guildRecord = inFile.ReadLine()) != null)
                {
                    string[] guildInfo = guildRecord.Split('\t', '-');
                    string guildId = guildInfo[0];
                    string guildName = guildInfo[1];
                    string guildServer = guildInfo[2];

                    //parse the guild ID to an unsigned integer
                    uint.TryParse(guildId, out uintGuildId);

                    //add the guilds to a dictionary so we can access them
                    Guild newGuild = new Guild(uintGuildId, guildName, guildServer);
                    guilds.Add(uintGuildId, newGuild);
                }
            }
            return guilds;
        }

        public int CompareTo(Object alpha)
        {
            //checking for null values
            if (alpha == null) throw new ArgumentNullException();

            //typecasting to a guild
            Guild guildToCompare = alpha as Guild;

            // Protect against a failed typecasting
            if (guildToCompare != null)
                return name.CompareTo(guildToCompare.name);
            else
                throw new ArgumentException("[Guild]:CompareTo argument is not a Guild");
        }

        public override string ToString()
        {
            return (this.Name.PadRight(30) + "\t" + "[" + this.Server + "]");
        }
    }
}
