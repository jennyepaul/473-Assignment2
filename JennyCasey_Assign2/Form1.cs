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

                //make sure the items in the dropdown do not repeat
                if (!Race_Dropdown.Items.Contains(i.Value.Race))
                {
                    //load the drop downs with the appropriate items 
                    Race_Dropdown.Items.Add(i.Value.Race);
                }
                if (!Class_Dropdown.Items.Contains(i.Value.Classes))
                {
                    Class_Dropdown.Items.Add(i.Value.Classes);
                }
            }
            foreach (var m in guildDictionary)
            {
                guildListBox.Items.Add(m.Value);
            }

            //sort the list boxes
            playerListBox.Sorted = true;
            guildListBox.Sorted = true;

            //set up everything to get ready to add a new guild
            serverDropDown.Items.Add("Beta4Azeroth");
            serverDropDown.Items.Add("TKWasASetback");
            serverDropDown.Items.Add("ZappyBoi");

            guildTypeDropDown.Items.Add(Type.Casual);
            guildTypeDropDown.Items.Add(Type.Mythic);
            guildTypeDropDown.Items.Add(Type.PVP);
            guildTypeDropDown.Items.Add(Type.Questing);
            guildTypeDropDown.Items.Add(Type.Raiding);

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
                            outputBox.AppendText(String.Format("Name: {0,-20} \t Race: {1,-10} Level: {2,-5} Guild: {3,-10} \n", 
                                player.Value.Name, player.Value.Race, player.Value.Level, guildName));
                        }
                    }                       
                }
                else
                {
                    outputBox.AppendText(String.Format("Name: {0,-20} \t Race: {1,-10} Level: {2,-5} Guild: NONE \n",
                        player.Value.Name, player.Value.Race, player.Value.Level));
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
                                    outputBox.AppendText("Name: " + player.Value.Name + "\tRace: " + player.Value.Race +
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

        private void Class_Dropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Class_Dropdown.SelectedItem != null)
            {
                //clears the dropdown items
                Role_Dropdown.Items.Clear();

                //the role dropdown items are added based on which class was selected 
                switch (Class_Dropdown.SelectedIndex)
                {
                    case 0: //Warrior
                        Role_Dropdown.Items.Add(Role.Tank);
                        Role_Dropdown.Items.Add(Role.DPS);
                        break;
                    case 1://Mage
                    case 4://Warlock
                    case 5://Rogue
                    case 7://Hunter
                        Role_Dropdown.Items.Add(Role.DPS);
                        break;
                    case 2: //Druid
                    case 6: //Paladin
                        Role_Dropdown.Items.Add(Role.Tank);
                        Role_Dropdown.Items.Add(Role.DPS);
                        Role_Dropdown.Items.Add(Role.Healer);
                        break;
                    case 3: //Priest
                    case 8: //Shaman
                        Role_Dropdown.Items.Add(Role.DPS);
                        Role_Dropdown.Items.Add(Role.Healer);
                        break;
                }
            }
        }

        private void AddPlayer_Button_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            //if there is text in the name text box, and all drop downs have an item selected, then we
            //can make the new player
            if (Name_Textbox.Text != "" && Race_Dropdown.SelectedIndex > -1
                     && Class_Dropdown.SelectedIndex > -1 && Role_Dropdown.SelectedIndex > -1)
            {

                var playerName = Name_Textbox.Text;
                Class playerClass = (Class)Class_Dropdown.SelectedItem;
                Race playerRace = (Race)Race_Dropdown.SelectedItem;
                Role playerRole = (Role)Role_Dropdown.SelectedItem;

                //generate a random ID
                Random randomID = new Random();
                uint playerID = (uint)randomID.Next(00000000, 100000000);

                //create a new player
                Player newPlayer = new Player(playerID, playerName, playerRace, playerClass, 0, 0, 0);

                //add that player to the listbox and dictionary
                playerListBox.Items.Add(newPlayer);
                playerDictionary.Add(playerID, newPlayer);


                //clears the textbox and the dropdown boxes after new player is added
                Name_Textbox.Text = "";
                Class_Dropdown.SelectedIndex = -1;
                Race_Dropdown.SelectedIndex = -1;
                Role_Dropdown.SelectedIndex = -1;

                //output a success message
                outputBox.AppendText("New player '" + playerName + "' successfully created!");
            }
            //else we are missing some needed info, so identify what is missing and output error message
            else
            {
                if (Name_Textbox.Text == "")
                {
                    outputBox.Text = "Please choose a name for this new Player.";
                }
                if (Race_Dropdown.SelectedIndex == -1)
                {
                    outputBox.Text = "Please choose a race for this new Player.";
                }
                if (Class_Dropdown.SelectedIndex == -1)
                {
                    outputBox.Text = "Please choose a class for this new Player.";
                }
                if (Role_Dropdown.SelectedIndex == -1)
                {
                    outputBox.Text = "Please choose a role for this new Player.";
                }
            }
            
        }

        private void addGuildButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            //if user has given values for all needed info, we can go ahead with creating the guild
            if((guildNameBox.Text != "") && (serverDropDown.SelectedIndex != -1) && (guildTypeDropDown.SelectedIndex != -1))
            {
                //get the name entered the the server that was chosen
                var guildName = guildNameBox.Text;
                string server = serverDropDown.Text;

                //might have to add to guild class a space for the type of guild?

                //generate a random ID
                Random randomID = new Random();
                uint guildID = (uint)randomID.Next(00000000, 100000000);

                //create a new guild
                Guild newGuild = new Guild(guildID, guildName, server);

                //add that guild to the listbox and dictionary
                guildListBox.Items.Add(newGuild);
                guildDictionary.Add(guildID, newGuild);

                //clear the textbox once they added
                guildNameBox.Text = " ";

                //clear both drop downs
                serverDropDown.SelectedIndex = -1;
                guildTypeDropDown.SelectedIndex = -1;

                //output a success message
                outputBox.AppendText("New guild '" + guildName + "' successfully created!");

            }
            //else we are missing needed info, so identify what is missing and print out message
            else
            {
                if (guildNameBox.Text == "")
                {
                    outputBox.Text = "Please enter a name for the new guild!";
                }
                if (serverDropDown.SelectedIndex == -1)
                {
                    outputBox.Text = " Please pick a server for the guild!";
                }
                if (guildTypeDropDown.SelectedIndex == -1)
                {
                    outputBox.Text = "Please pick a type for the guild";
                }
            }
            
        }
    }
}
