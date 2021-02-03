using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JennyCasey_Assign2
{
    public partial class Form1 : Form
    {
        private Dictionary<uint, Player> playerDictionary;
        private Dictionary<uint, Guild> guildDictionary;
        List<Player> players = new List<Player>();
        List<Guild> guilds = new List<Guild>();

        public Form1()
        {
            InitializeComponent();

            //create a new object and build the two dictionaries
            Player newplayer = new Player();
            Guild newguild = new Guild();
            playerDictionary = newplayer.BuildPlayerDictionary();
            guildDictionary = newguild.BuildGuildDictionary();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
      
            //populate the playerListBox and guildListBox
            foreach (var i in playerDictionary)
            {
                playerListBox.Items.Add(i.Value);
            }
            foreach (var m in guildDictionary)
            {
                guildListBox.Items.Add(m.Value);
            }

            //sort the list boxes
            playerListBox.Sorted = true;
            guildListBox.Sorted = true;

            //set up everything to get ready to add a new player
            raceDropDown.Items.Add(Race.Forsaken);
            raceDropDown.Items.Add(Race.Orc);
            raceDropDown.Items.Add(Race.Tauren);
            raceDropDown.Items.Add(Race.Troll);

            classDropDown.Items.Add(Class.Druid);
            classDropDown.Items.Add(Class.Hunter);
            classDropDown.Items.Add(Class.Mage);
            classDropDown.Items.Add(Class.Paladin);
            classDropDown.Items.Add(Class.Priest);
            classDropDown.Items.Add(Class.Rogue);
            classDropDown.Items.Add(Class.Shaman);
            classDropDown.Items.Add(Class.Warlock);
            classDropDown.Items.Add(Class.Warrior);

        }
        private void SearchCriteriaButton_Click(object sender, EventArgs e)
        {
            //clear both the list boxes, so we can repopulate
            guildListBox.Items.Clear();
            playerListBox.Items.Clear();

            //********************************
            //GUILD TEXT BOX SEARCH CRITERA
            //********************************
            //search the guild list box
            string serverFilter = searchGuildTextBox.Text;
            //if user has entered something into the text box, let's filter
            if (!string.IsNullOrEmpty(searchGuildTextBox.Text))
            {
                foreach (var name in guildDictionary)
                {
                    //add the ones that match the criteria back in
                    if (name.Value.Server == serverFilter)
                    {
                        //add the guild value back in
                        guildListBox.Items.Add(name.Value);
                    }
                }
            }
            //else if they havent entered anything/is empty, display all items
            else if (serverFilter == " ")
            {
                foreach (var guild in guildDictionary)
                {
                    guildListBox.Items.Add(guild.Value);
                }
            }                  

            //********************************
            //PLAYER TEXT BOX SEARCH CRITERA
            //********************************
            string nameFilter = searchPlayerTextbox.Text;
            //if user has entered something into the text box, let's filter
            if (!string.IsNullOrEmpty(searchPlayerTextbox.Text))
            {
                //clear the player list box
                foreach (var name in playerDictionary)
                {
                    //add the ones that match the criteria back in
                    if (name.Value.Name.StartsWith(nameFilter))
                    {
                        //add the player value back in
                        playerListBox.Items.Add(name.Value);
                    }
                }
            }
            //else if they havent entered anything/is empty, display all items
            else if (nameFilter == " ")
            {
                foreach (var player in playerDictionary)
                {
                    playerListBox.Items.Add(player.Value);
                }
            }
        }

        private void LeaveGuildButton_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();

            //check that a player and guild has been selected
            if (playerListBox.SelectedIndex == -1)
            {
                outputBox.Text = "No player selected";
                return;
            }
            else
            {
                //parse the info
                string playerName= ((Player)playerListBox.SelectedItem).Name;

                outputBox.Text = "Player " + playerName + "is leaving guild";
                //pass the player dictionary and the player name to the leave guild function
                player1.PlayerLeaveGuild(playerDictionary, playerName);
                outputBox.Text = "Player successfully left guild!";
            }
        }
        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            // check that a player and guild has been selected
            if ((playerListBox.SelectedItem.Equals(null)) && (guildListBox.SelectedItem.Equals(null)))
            {
                outputBox.Text = "No player and guild selected";
                return;
            }
            else
            {
                //need to put some catch or double check, cause if user doesnt click a guild we error out here
                //parse the info
                string playerName = ((Player)playerListBox.SelectedItem).Name;
                uint id = ((Guild)guildListBox.SelectedItem).ID;


                //pass the player dictionary, player name, and guildID to function to join a guild
                player1.PlayerJoinGuild(playerDictionary, playerName, id);
                outputBox.Text = "Player successfully joined the guild!";
            }
        }

        private void clearSearchCriteria_Click(object sender, EventArgs e)
        {
            //clear both the list boxes, so we can repopulate
            guildListBox.Items.Clear();
            playerListBox.Items.Clear();

            //reset the textbox
            searchPlayerTextbox.Text = " ";
            searchGuildTextBox.Text = " ";
            //repopulate playerListBox
            foreach (var player in playerDictionary)
            {
                playerListBox.Items.Add(player.Value);
            }

            //repopulate guildListBox
            foreach (var guild in guildDictionary)
            {
                guildListBox.Items.Add(guild.Value);
            }
        }

        private void GuildRosterButton_Click(object sender, EventArgs e)
        {

            //clear the output box
            outputBox.Clear();
            
            //iterate through the player dictionary, match up the guild ID in the player
            //dictionary with the key of the guild dictionary, then append that text to output
           foreach (var player in playerDictionary)
           { 
                if (player.Value.GuildID > 0)
                {
                    foreach (var guild in guildDictionary)
                    {
                        if (player.Value.GuildID == guild.Key)
                        {
                            string guildName = guild.Value.Name;
                            outputBox.AppendText("Name: " + player.Value.Name.PadRight(20) + "\tRace: " + player.Value.Race +
                                    "\tLevel: " + player.Value.Level + "\t\tGuild: " + guildName + "\n");
                        }
                    }                       
                }
                else
                {
                    outputBox.AppendText("Name: " + player.Value.Name.PadRight(20) + "\tRace: " + player.Value.Race +
                                   "\tLevel: " + player.Value.Level + "\t\tGuild: NONE \n");
                }               
            }
        }

        private void DisbandGuildButton_Click(object sender, EventArgs e)
        {
            int playerCount = 0;

            //add try-catch block to catch if no guildList box item selected
            uint guildIDToFind = ((Guild)guildListBox.SelectedItem).ID;

            //not sure if we have to verify its the right server?
            //string guildServerToFind = ((Guild)guildListBox.SelectedItem).Server;
            //select guild then click this button
            //if the guild name selected is not null, then we must remove it from the list
            //then set the guilID in the player dictionary where this was to 0 and remove it from the guild dictionary

            
            //remove the selected item from the listbox
            if (guildListBox.SelectedItem != null)
            {
                guildListBox.Items.Remove(guildListBox.SelectedItem);
            }

            //remove the guild from the players info
            foreach(var player in playerDictionary)
            {
                if(guildIDToFind == player.Value.GuildID)
                {
                    playerCount++;
                    player.Value.GuildID = 0;
                }
            }
            outputBox.Clear();
            foreach (var guild in guildDictionary)
            {
                if (guildIDToFind == guild.Key)
                {
                    outputBox.AppendText(playerCount + " players have been disbanded from " + guild.Value.Name + "\t[" 
                                            + guild.Value.Server + "]\n");
                }              
            }            
        }

        private void playerListBox_DoubleClick(object sender, EventArgs e)
        {
            //clear the output box
            outputBox.Clear();
            if(playerListBox.SelectedItem != null)
            {
                //get the name of the selected player
                string playerName = ((Player)playerListBox.SelectedItem).Name;

                //NEED TO FIND A WAY TO MAKE A FUNCTION OF THIS SINCE USING THIS PRINT OUT
                //IN A FEW SPOTS
                foreach (var player in playerDictionary)
                {
                    //Ssearching for match of player name of selected item in dictionary, if we find a match
                    //check if they have an associated guild, if so print out info including guild name
                    if (playerName == player.Value.Name)
                    {
                        if (player.Value.GuildID > 0)
                        {
                            foreach (var guild in guildDictionary)
                            {
                                if (player.Value.GuildID == guild.Key)
                                {
                                    string guildName = guild.Value.Name;
                                    outputBox.AppendText("Name: " + player.Value.Name.PadRight(20) + "\tRace: " + player.Value.Race +
                                            "\tLevel: " + player.Value.Level + "\t\tGuild: " + guildName + "\n");
                                }
                            }
                        }
                        //else they don't have a guild associated with it, so don't print guild info
                        else
                        {
                            outputBox.AppendText("Name: " + player.Value.Name.PadRight(20) + "\tRace: " + player.Value.Race +
                                           "\tLevel: " + player.Value.Level + "\n");
                        }

                    }
                }

            }

        }

        private void classDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if(classDropDown.SelectedItem != null)
            {
                //clear any previous selections
                roleDropDown.Items.Clear();

                //add the right roles depending what item was selected from the class drop down
                if(classDropDown.SelectedItem.Equals(Class.Warrior))
                {
                    roleDropDown.Items.Add(Role.Tank);
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if(classDropDown.SelectedItem.Equals(Class.Mage))
                {
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if(classDropDown.SelectedItem.Equals(Class.Druid))
                {
                    roleDropDown.Items.Add(Role.Tank);
                    roleDropDown.Items.Add(Role.Healer);
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if(classDropDown.SelectedItem.Equals(Class.Priest))
                {
                    roleDropDown.Items.Add(Role.Healer);
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if(classDropDown.SelectedItem.Equals(Class.Warlock))
                {
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if (classDropDown.SelectedItem.Equals(Class.Rogue))
                {
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if (classDropDown.SelectedItem.Equals(Class.Paladin))
                {
                    roleDropDown.Items.Add(Role.Tank);
                    roleDropDown.Items.Add(Role.Healer);
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if (classDropDown.SelectedItem.Equals(Class.Hunter))
                {
                    roleDropDown.Items.Add(Role.DPS);
                }
                else if (classDropDown.SelectedItem.Equals(Class.Shaman))
                {
                    roleDropDown.Items.Add(Role.DPS);
                    roleDropDown.Items.Add(Role.Healer);
                }
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            //get the playername, and set the class, race, and role
            var playerName = playerNameInput.Text;
            Class playerClass = (Class)classDropDown.SelectedItem;
            Race playerRace = (Race)raceDropDown.SelectedItem;
            Role playerRole = (Role)roleDropDown.SelectedItem;

            //generate a random ID
            Random randomID = new Random();
            uint playerID = (uint)randomID.Next(00000000, 100000000);

            //create a new player
            Player newPlayer = new Player(playerID, playerName, playerRace, playerClass, 0, 0, 0);

            //add that player to the listbox and dictionary
            playerListBox.Items.Add(newPlayer);
            playerDictionary.Add(playerID, newPlayer);

        }
    }
}
