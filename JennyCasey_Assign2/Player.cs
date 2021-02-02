/* CSCI 473
 * Assignment 1
 * TEAM: JennyCasey
 * Contributors: Jennifer Paul (z1878099) and Casey McDermott (z1878096) 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace JennyCasey_Assign2
{
    public enum Race { Orc, Troll, Tauren, Forsaken };
    public enum Class { Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman };

    /**************************************************************************************************************************
     * Class - Player
     * 
     * The player class is used store the information of each individual player. 
     * 
     * - There are 3 constants that store the max level, the total gear slots, and the max inventory size of 
     * each player.
     * - There are 8 private attributes that stores information about each individual players id, name, race, 
     * level, experiance, guild ID, gear, and the inventory. 
     * - The player class has an IComparable interface in order to sort the player based on their names.
     * - Player Class Methods: 
     *             BuildPlayerDictionary => This method reads from the players.txt file and creates a player
     *                                 dictionary. 
     *             EquipGear => This method corresponds with option '7', and places the item the player wants
     *                              to equip into the players gear list.
     *             UnequipGear => This method corresponds with option '8' and removes the item the player wants 
     *                              to remove from the players gear list. 
     *             LevelUp => This method corresponds with option '9', and levels up the player by using the 
     *                              amount of experiance points the player currently has. 
     *             FindGuildName => This method splits the records from the guild.txt file and stores them in a 
     *                              dictionary so its easy to sear via the key.
     *             FindGuildID => This method takes the name of guild and finds the corresponding ID number by 
     *                              searching the guild dictionary.
     *             EmptyGear => This method is called in the PrintGearListForPlayer and prints "empty" where the
     *                                  index is zero in the gear array.
     *             PrintGearListForPlayer => This method corresponds with option '4' and prints the gear that are 
     *                                       equipped for a specific player, printing empty where there is no 
     *                                       gear equipped.
     *             PlayerLeaveGuild => This method corresponds with option '5' and removes the player from the guild
     *                                 they are associated with (if they are associated with one).
     *             PlayerJoinGuild => This method corresponds with option '6' and joins the player to the guild that 
     *                                 the player has chosen.
     *             PlayerEquipGear => This method corresponds with option '7' and asks for the players name and their 
     *                                item and checks to see if they player and item match up to one stored in the 
     *                                dictionaries and then calls EquipGear.
     *             PlayerUnequipGear => This method corresponds with option '8', and asks for the players name and 
     *                                  there slot number they would like to remove their gear from and then checks to 
     *                                  make sure the player is in the dictionary before claling UnequipGear.
     *             AwardExperiance => This method corresponds with option '9' and asks for players name and the amount 
     *             SortPlayerNames => This method corresponds with option '11' which prints out the names of the players
     *                                in order alphabetically. 
     * ************************************************************************************************************************/
    public class Player //: IComparable
    {
        //constants for program
        private static uint MAX_LEVEL = 60;
        private readonly uint id;
        private readonly string name;
        private readonly Race race;
        private readonly Class classes;
        private uint level;
        private uint exp;
        private uint guildId;

        //boolean attributes to tell where to equip gear next
        //if both gear slots occupied
        //private bool isRingLowerSlotNext = true;
        //private bool isTrinketLowerSlotNext = true;

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
            set { }
        }

        //only a getter, since only readonly
        public string Name
        {
            get { return name; }
        }

        //only a getter, since only readonly
        public Race Race
        {
            get { return race; }
            set { }
        }

        public Class Classes
        {
            get { return classes; }
            set { }
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


                    uint.TryParse(parameter[0], out parsed_id);
                    Enum.TryParse(parameter[2], out parsed_race);
                    Enum.TryParse(parameter[3], out parsed_classes);
                    uint.TryParse(parameter[4], out parsed_level);
                    uint.TryParse(parameter[5], out parsed_exp);
                    uint.TryParse(parameter[6], out parsed_guildID);

                    Player newPlayer = new Player(parsed_id, parameter[1], parsed_race, parsed_classes, parsed_level, parsed_exp, parsed_guildID);

                    players.Add(parsed_id, newPlayer);
                }
            }
            return players;
        }

        public void printGuildNames (Dictionary<uint, string>guilds)
        {
            foreach (var i in guilds)
            {
                Console.WriteLine(i.Value);
            }
        }
        public void LevelUp(uint experience)
        {
            uint nextLevel = (Level * 1000);
            //gaining a level is when experience = (current level * 1000);
            //so if we were at level 3 and wanted to go to level 4 we would need 3000 exp
            if (experience >= nextLevel)
            {
                experience /= nextLevel;
                Level += experience;
            }
            else
            {
                Level += 0;
            }
        }

         public Dictionary<uint,string> BuildGuildDictionary()
         {
             string guildRecord;
             uint uintGuildId;
             var guilds = new Dictionary<uint, string>();
             using (StreamReader inFile = new StreamReader("../../guilds.txt"))
             {
                 while ((guildRecord = inFile.ReadLine()) != null)
                 {
                     string[] guildInfo = guildRecord.Split('\t');
                     string guildId = guildInfo[0];
                     string guildName = guildInfo[1];
                     //parse the guild ID to an unsigned integer
                     uint.TryParse(guildId, out uintGuildId);
                     //add the guilds to a dictionary so we can access them 
                     guilds.Add(uintGuildId, guildName);
                 }
             }
             return guilds;
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
                  if (player.Value.Name == playerName)
                  {                     
                      //set the guild to the guild ID and print out that player joined
                      dictionary[player.Key].GuildID = guildID;
                  }
              }
          }
          /*
         public void AwardExperience(Dictionary<uint, Player> dictionary)
         {
             bool playerIsFound = false;
             //get the player name then do a lookup in the dictionary for that player
             Console.Write("Enter the player name: ");
             string playerName4 = Console.ReadLine();
             //get the experience to award then add that to the exp the player already has
             Console.Write("Enter the amount of experience to award: ");
             string experience = Console.ReadLine();
             uint uintExperience;
             uint.TryParse(experience, out uintExperience);
             //goes through the players dictionart
             foreach (var player in dictionary)
             {
                 //if the name the user entered is a value in the dictionary, then we want to add experience
                 //but only if the level is less than 60 (since that is MAX_LEVEL)
                 if (player.Value.Name == playerName4)
                 {
                     playerIsFound = true;
                     dictionary[player.Key].Exp = uintExperience;
                     //if enough experience was entered, we may need to level up
                     if ((uintExperience > 1000) && (dictionary[player.Key].Level < 60))
                     {
                         Console.WriteLine("Ding!" + "\n" + "Ding!" + "\n" + "Ding!");
                         dictionary[player.Key].LevelUp(uintExperience);
                     }
                 }
             }
             if (playerIsFound == false)
             {
                 Console.WriteLine("Unknown player");
             }
         }
         public int CompareTo(Object alpha)
         {
             //checking for null values
             if (alpha == null) throw new ArgumentNullException();
             //typecasting to an Item
             Player playerToCompare = alpha as Player;
             // Protect against a failed typecasting
             if (playerToCompare != null)
                 return name.CompareTo(playerToCompare.name);
             else
                 throw new ArgumentException("[Player]:CompareTo argument is not an Player");
         }
         public void SortPlayerNames(Dictionary<uint, Player> dictionary)
         {
             //player sorted set
             SortedSet<Player>PlayerSortedSet = new SortedSet<Player>();
             //add the players to the sorted set
             foreach (var i in dictionary)
             {
                 PlayerSortedSet.Add(i.Value);
             }
             //print the sorted set out
             foreach (var i in PlayerSortedSet)
             {
                  Console.WriteLine(i);
             }
         }*/
        public override string ToString()
        {
            return (this.name.PadRight(15) + "\t" + this.Race  + "\t" +this.Level);
        }
    }
}