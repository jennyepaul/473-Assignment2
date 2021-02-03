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

        private void GuildRosterButton_Click(object sender, EventArgs e)
        {
            //clear the output box
            outputBox.Clear();

            foreach(var i in playerDictionary)
            {
                outputBox.Text = "hey hey";
            }
            
        }

        private void DisbandGuildButton_Click(object sender, EventArgs e)
        {
            uint guildIDToFind = ((Guild)guildListBox.SelectedItem).ID;
            //select guild then click this button
            //if the guild name selected is not null, then we must remove it from the list
            //then set the guilID in the player dictionary where this was to 0 and remove it from the guild dictionary

            //remove the selected item from the listbox
            if (guildListBox.SelectedItem != null)
            {
                guildListBox.Items.Remove(guildListBox.SelectedItem);
            }
        }
    }
}
