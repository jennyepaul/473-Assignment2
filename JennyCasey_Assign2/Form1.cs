using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //confused what form object this is??
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
                string[] playerText = playerListBox.Text.Split('\t');

                //pass the player dictionary and the player name to the leave guild function
                player1.PlayerLeaveGuild(playerDictionary, playerText[1]);
                outputBox.Text = "Player successfully left guild!";
            }
        }
        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            uint guildID;
            // check that a player and guild has been selected
            if ((playerListBox.SelectedIndex == -1) && (guildListBox.SelectedIndex == -1))
            {
                outputBox.Text = "No player and guild selected";
                return;
            }
            else
            {
                //parse the info
                string[] playerText = playerListBox.Text.Split('\t');
                string[] guildText = guildListBox.Text.Split('\t');

                //parse the guild ID to a uint, not a string
                uint.TryParse(guildText[0], out guildID);

                //pass the player dictionary, player name, and guildID to function to join a guild
                player1.PlayerJoinGuild(playerDictionary, playerText[1], guildID);
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

        private void AddPlayer_Button_Click(object sender, EventArgs e)
        {
            //PROBLEM 
                //CAN ONLY ADD ONLY PLAYER, IF YOU TRY TO ADD ANOTHER IT TELLS YOU THE KEY IS NOT UNIQUE... 
                //NEED TO GIVE ERROR MESSAGE IF EACH DROPDOWN DOESNT HAVE AN ITEM SELECTED

            //if the name text box is filled out and the role dropdown has selected something
            if (this.Name_Textbox.Text != "") //&& this.Race_Dropdown.SelectedIndex == -1)
            { 

                //NEED TO FIGURE OUT HOW TO MAKE UNIQUE ID HERE 
                uint t = 0;
                uint Unique_Id = t;

                foreach (var i in playerDictionary)
                {
                    if (Unique_Id == i.Value.ID)
                    {
                        Unique_Id = t++;
                    }
                }

                //create a new player
                Player new_player = new Player
                {
                    ID = Unique_Id,
                    Name = this.Name_Textbox.Text,
                    //Level = 1,
                    Classes = (Class)this.Class_Dropdown.SelectedItem,
                    Race = (Race)this.Race_Dropdown.SelectedItem
                    //Exp = 1,
                    //GuildID = 0
                };

                //add the new player to the player dictionary
                playerDictionary.Add(new_player.Key, new_player);

                //print out the player values (with the new player) in the player list box
                playerListBox.Items.Add(new_player);
                playerListBox.Items.Add(new_player.ID);
              
            }
            else
            {
                outputBox.Text = "Please choose a name for this new Player.";
            }
        }

        private void Class_Dropdown_DropDownClosed(object sender, EventArgs e)
        {
            //clear the Role dropdown items 
            Role_Dropdown.Items.Clear();

            string[] Role_Types = { "Tank", "DPS", "Healer" };

            //check to make sure an item was selected in the classes dropdown
            if (Class_Dropdown.SelectedIndex > -1)
            {
                //the role dropdown is filled based on which class was selected
                switch (Class_Dropdown.SelectedIndex)
                {
                    case 0: //Warrior
                        Role_Dropdown.Items.Add(Role_Types[0]);
                        Role_Dropdown.Items.Add(Role_Types[1]);
                        break;
                    case 1://Mage
                    case 4://Warlock
                    case 5://Rogue
                    case 7://Hunter
                        Role_Dropdown.Items.Add(Role_Types[1]);
                        break;
                    case 2: //Druid
                    case 6: //Paladin
                        Role_Dropdown.Items.Add(Role_Types[0]);
                        Role_Dropdown.Items.Add(Role_Types[1]);
                        Role_Dropdown.Items.Add(Role_Types[2]);
                        break;
                    case 3: //Priest
                    case 8: //Shaman
                        Role_Dropdown.Items.Add(Role_Types[1]);
                        Role_Dropdown.Items.Add(Role_Types[2]);
                        break; 
                    default:
                        break;
                }
            }
        }
    }
}
