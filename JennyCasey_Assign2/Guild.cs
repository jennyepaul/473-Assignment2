using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace JennyCasey_Assign2
{
    class Guild
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
        //alternate constructor
        public Guild(uint id, string name, string server)
        {
            this.id = id;
            this.name = name;
            this.server = server;
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
        public string FindGuildName(Dictionary<uint,Guild> dictionary, uint ID)
        {
            string name;
            //search the guild dictionary for the key and return the name
            foreach (var keyValue in dictionary)
            {
                if (keyValue.Key == ID)
                {
                    name = keyValue.Value.Name;
                    return name;
                }
            }
            return "Guild Not found";
        }
        public override string ToString()
        {
            return (this.Name.PadRight(30) + "\t" + "[" + this.Server + "]");
        }
    }
}
