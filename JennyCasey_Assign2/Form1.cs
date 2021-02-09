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
    /**************************************************************************************************************************
     * Class - Form1
     * 
     * The purpose of the Form1 class was to give functionality to the buttons on the form used for this assignment.
     * 
     * - There are two private attributes that are the dictionaries for the guilds and the players. 
     * - Form1 Class Methods: 
     *             Form1 => Constructor that initializes the component and then builds the guild & player dictionary
     *             Form1_Load => This method loads the "Race" and "Class" dropdowns under "Create New Player" with the appropriate
     *                           terms.
     *             SearchCriteriaButton_Click => This method checks which search box ("Search Player by Name" or "Search Guild
     *                                           by Server") the user has entered information into. Then, searches in either the
     *                                           guild dictionary or the player dictionary for matches. Finally, adds those matches
     *                                           to the appropriate list box to be viewed by the user. 
     *                                           
     *             LeaveGuildButton_Click => This method will have a player leave a guild, only if the user has clicked on a player
     *                                       name from the player list box and then clicked the "Leave Guild" button
     *                                       
     *             JoinGuildButton_Click =>  This method has a player who has no guild association join a guild once the user clicks
     *                                       on the player name from the listbox and a guild name they want to join from the guild
     *                                       list box. If both are not selected, then there will be an error message displayed. 
     *                                       
     *             clearSearchCriteria_Click => This method will clear the search criteria that has been entered, so that all of the 
     *                                          players and guilds are available to see, and the text area will be cleared, so the user
     *                                          can start a new search when needed.
     *                                          
     *             GuildRosterButton_Click => This method will print the players that are part of the selected guild the user has 
     *                                        selected. The output will be displayed (and formatted) in the "output" box. If no 
     *                                        guild name has been selected from the listbox, there will be an error message out-
     *                                        putted to the output box. 
     *                                        
     *             DisbandGuildButton_Click => This method will disband a guild that has been selected. Once the guild is 
     *                                          selected and the button is pushed, the guild name will disappear from the listbox
     *                                          and any player that had that guild associated with them will no longer have a guild.
     *                                          
     *             playerListBox_DoubleClick => This method will print the player info to the output box if a user double clicks on 
     *                                          a player's name. 
     *             
     *             Class_Dropdown_SelectedValueChanged => This method loads the "Role" dropdown under "Create New Player" with the 
     *                                                    appropriate roles, once the class has been selected for the class dropdown.
     *                                               
     *             AddPlayer_Button_Click => This method first checks to makes sure there is text in the name box and all the 
     *                                       dropdowns in "Create New Player" have been selected. Then, it creates a new player 
     *                                       based on the criteria selected and assigns the player a unique id. Finally, it clears
     *                                       the textbox and the dropdowns and outputs a success message in the output text box. 
     *                                       
     *             addGuildButton_Click=> This method will add a guild to the listbox, and the guild dictionary once it is created.
     *                                    To create the guild, the user needs to enter a name, and then pick a server and type of guild.
     * ************************************************************************************************************************/
    public partial class Form1 : Form
    {
        private Dictionary<uint, Player> playerDictionary;
        private Dictionary<uint, Guild> guildDictionary;


        public Form1()
        {
            InitializeComponent();

            //create a new player and guild object and build the two dictionaries
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

            //reset the index 
            playerListBox.SelectedIndex = -1;
        }
        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            //clear any previous data in the output box
            outputBox.Clear();

            Player player1 = new Player();

            // check that a player and guild has been selected, if one or the other hasn't been selected
            //output the appropriate error message
            if ((playerListBox.SelectedIndex == -1 ) || (guildListBox.SelectedIndex == -1))
            {
                if(playerListBox.SelectedIndex == -1)
                {
                    outputBox.Text = "No player selected, please select a player";
                }
                if(guildListBox.SelectedIndex == -1)
                {
                    outputBox.Text = "No guild selected, please select a guild";
                }
            }
            else
            {
                string playerName = ((Player)playerListBox.SelectedItem).Name;
                uint id = ((Guild)guildListBox.SelectedItem).ID;


                //pass the player dictionary, player name, and guildID to function to join a guild
                player1.PlayerJoinGuild(playerDictionary, playerName, id);
                outputBox.Text = "Player successfully joined the guild!";
            }

            //reset the player selected index and guild selected index
            playerListBox.SelectedIndex = -1;
            guildListBox.SelectedIndex = -1;
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
            Guild newGuild = new Guild();
            //clear the output box
            outputBox.Clear();

            //if the user has picked a guild to print the roster for, then print the info
            if (guildListBox.SelectedIndex != -1)
            {
                //get the guild ID, name, and server of the selected item
                uint id = ((Guild)guildListBox.SelectedItem).ID;
                string guildName = ((Guild)guildListBox.SelectedItem).Name;
                string server = ((Guild)guildListBox.SelectedItem).Server;

                outputBox.AppendText("Guild Listing for " + guildName.PadRight(30) + "\t" + "[" + server + "]\n");
                outputBox.AppendText("--------------------------------------------------------------------------\n");

                //go through the player dictionary and print out any player that is part of that guild
                foreach (var player in playerDictionary)
                {
                    //if the player guild ID matches the one selected, then find the guild ID in the dictionary
                    //and print out the info
                    if (player.Value.GuildID == id)
                    {
                        outputBox.AppendText(String.Format("Name: {0,-20} \t Race: {1,-10} Level: {2,-5} Guild: {3,-10} \n",
                              player.Value.Name, player.Value.Race, player.Value.Level, guildName));
                    }
                }
            }
            else
            {
                outputBox.Text = "Please select a guild to see its roster";
            }

            //reset the selected index
            guildListBox.SelectedIndex = -1;
        }
        private void DisbandGuildButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            //check to make sure the user has picked a guild to disband
            if(guildListBox.SelectedIndex != -1)
            {
                int playerCount = 0;

                //add try-catch block to catch if no guildList box item selected
                uint guildIDToFind = ((Guild)guildListBox.SelectedItem).ID;
                //remove the selected item from the listbox
                if (guildListBox.SelectedItem != null)
                {
                    guildListBox.Items.Remove(guildListBox.SelectedItem);
                }

                //remove the guild from the players info
                foreach (var player in playerDictionary)
                {
                    if (guildIDToFind == player.Value.GuildID)
                    {
                        playerCount++;
                        player.Value.GuildID = 0;
                    }
                }
                foreach (var guild in guildDictionary)
                {
                    if (guildIDToFind == guild.Key)
                    {
                        outputBox.AppendText(playerCount + " players have been disbanded from " + guild.Value.Name + "\t["
                                                + guild.Value.Server + "]\n");
                    }
                }
            }
            //if they have not picked a guild, output error
            else
            {
                outputBox.Text = "Please select a guild first, before disbanding";
            }

            //reset the selected index
            guildListBox.SelectedIndex = -1;
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
                                    outputBox.AppendText(String.Format("Name: {0,-20} \t Race: {1,-10} Level: {2,-5} Guild: {3,-10} \n",
                                        player.Value.Name, player.Value.Race, player.Value.Level, guildName));
                                }
                            }
                        }
                        //else they don't have a guild associated with it, so don't print guild info
                        else
                        {
                            outputBox.AppendText(String.Format("Name: {0,-20} \t Race: {1,-10} Level: {2,-5} Guild: NONE \n",
                                player.Value.Name, player.Value.Race, player.Value.Level));
                        }
                    }
                }
            }

            //reset the selected index for the player
            playerListBox.SelectedIndex = -1;
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
