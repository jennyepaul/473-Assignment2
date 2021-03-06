﻿/* CSCI473 
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
using System.IO;

namespace JennyCasey_Assign2
{
    public enum Race { Orc, Troll, Tauren, Forsaken };
    public enum Class { Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman };

    public enum Role { Tank, Healer, DPS };

    /**************************************************************************************************************************
     * Class - Player
     * 
     * The player class is used store the information of each individual player. 
     * 
     * - There are 1 constant that stores the max level. 
     * - There are 7 private attributes that stores information about each individual players id, name, race, 
     *   class, level, experiance, and guild ID.
     * - The player class has an IComparable interface in order to sort the player based on their names.
     * - Player Class Methods: 
     *            BuildPlayerDictionary => This method takes the information from the player.txt about the players and 
     *                                     places that information into a dictionary. 
     *            PlayerLeaveGuild => Takes the name of the player as an argument and searches the dictionary for the name 
     *                                provided. Once the name is located it sets the guild id associated with that name 
     *                                to zero, therefore indicating the player is no longer associated with a guild. 
     *            PlayerJoinGuild => Takes the name of the player, the desired guild id number and the dictionary as arguements. 
     *                               First it searches the dictionary for the name provided. Then once the name is found, it sets 
     *                               the players guild id to the desired guild id, therfore joining the guild. 
     *            
     * ************************************************************************************************************************/
    public class Player : IComparable
    {
        //constants for program
        private static uint MAX_LEVEL = 60;

        //private attributes
        private uint id;
        private string name;
        private Race race;
        private Class classes;
        private uint level;
        private uint exp;
        private uint guildId;

        // default constructor 
        public Player()
        {
            id = 0;
            name = "";
            race = 0;
            classes = 0;
            level = 0;
            exp = 0;
            guildId = 0;
        }


        //alternate constructor
        public Player(uint id, string name, Race race, Class classes, uint level, uint exp, uint guildId)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.classes = classes;
            this.level = level;
            this.exp = exp;
            this.guildId = guildId;
        }

        //only a getter, since only readonly
        public uint ID
        {
            get { return id; }
            set { id = value; }
        }

        //only a getter, since only readonly
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //only a getter, since only readonly
        public Race Race
        {
            get { return race; }
            set { race = value; }
        }

        public Class Classes
        {
            get { return classes; }
            set { classes = value; }
        }
        public uint Level
        {
            //free read/write acess so getter and setters
            get { return level; }
            set { level = value; }
        }

        public uint Exp
        {
            //free read/write acess so getter and setters
            get
            { return exp; }
            set
            {
                //nextLevel would be the current Level * 100)
                //set newLevel to Level since we don't want to alter the Level variable
                uint nextLevel = (Level * 1000);
                uint newLevel = Level;

                //if the experience is greater than the value of what the nextLevel would be, we would level up
                //so calculate what the ~possible~ newLevel of the player would be
                if (exp >= nextLevel)
                {
                    exp /= nextLevel;
                    newLevel += exp;

                }
                //if the current level OR the new level after experience is less than MAX_LEVEL
                //we can add the experience
                if ((Level < MAX_LEVEL) || (newLevel < MAX_LEVEL))
                {
                    //only incremnt exp if it does not exceed MAX_LEVEL
                    exp += value;
                }
                else
                {
                    //if its >= MAX_LEVEL then we just return
                    Console.WriteLine("Player already at max level");
                    exp += 0;
                    return;
                }
            }
        }

        public uint GuildID
        {
            //free read/write acess so getter and setters
            get { return guildId; }
            set { guildId = value; }
        }

        public Dictionary<uint, Player> BuildPlayerDictionary()
        {
            string playerRecord;
            var players = new Dictionary<uint, Player>();

            //read the player file
            using (StreamReader inFile = new StreamReader("../../players.txt"))
            {
                while ((playerRecord = inFile.ReadLine()) != null)
                {
                    uint parsed_id;
                    Race parsed_race;
                    Class parsed_classes;
                    uint parsed_level;
                    uint parsed_exp;
                    uint parsed_guildID;

                    string[] parameter = playerRecord.Split('\t');

                    //grab all the info
                    uint.TryParse(parameter[0], out parsed_id);
                    Enum.TryParse(parameter[2], out parsed_race);
                    Enum.TryParse(parameter[3], out parsed_classes);
                    uint.TryParse(parameter[4], out parsed_level);
                    uint.TryParse(parameter[5], out parsed_exp);
                    uint.TryParse(parameter[6], out parsed_guildID);

                    //create a new player object
                    Player newPlayer = new Player(parsed_id, parameter[1], parsed_race, parsed_classes, parsed_level, parsed_exp, parsed_guildID);

                    //add object to the dictionary
                    players.Add(parsed_id, newPlayer);
                }
            }
            return players;
        }

        public void PlayerLeaveGuild(Dictionary<uint, Player> dictionary, string playerName)
        {
            //search through the players dictionary for the username entered
            foreach (var player in dictionary)
            {
                //once we find it, set the flag, then set the guild to 0 since we want to leave
                if (player.Value.Name == playerName)
                {
                    dictionary[player.Key].GuildID = 0;
                }
            }

        }
        public void PlayerJoinGuild(Dictionary<uint, Player> dictionary, string playerName, uint guildID)
        {
            //search for the name that the user entered in the players dictionary
            foreach (var player in dictionary)
            {
                //if we find the player name in the dictionary
                if (player.Value.Name == playerName)
                {
                    //set the guild to the guild ID and print out that player joined
                    dictionary[player.Key].GuildID = guildID;
                }
            }
        }

        public int CompareTo(Object alpha)
        {
            //checking for null values
            if (alpha == null) throw new ArgumentNullException();
            //typecasting to a Player
            Player playerToCompare = alpha as Player;
            // Protect against a failed typecasting
            if (playerToCompare != null)
                return name.CompareTo(playerToCompare.name);
            else
                throw new ArgumentException("[Player]:CompareTo argument is not an Player");
        }

        public override string ToString()
        {
            return (this.name.PadRight(15) + "\t" + this.Classes + "\t" + this.Level);
        }
    }
}