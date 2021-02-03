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
            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            string letter = SearchPlayer_Textbox.Text;

            var list = new List<string>();
            string sub;

            if (letter != "")
            {
                Playerlistbox.Items.Clear();
            }

            foreach (var i in players)
            {
                sub = i.Value.Name.Substring(0, 1);
                list.Add(sub);
                if (letter == sub)
                {
                    Playerlistbox.Items.Add(string.Format("{0} \t {1} \t {2}", i.Value.Name.PadRight(10), i.Value.Race, i.Value.Level));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set the data source for the player and guild list box
            foreach(var i in playerDictionary)
            {
                Playerlistbox.Items.Add(i.Value);
            }
            foreach(var m in guildDictionary)
            {
                guildListBox.Items.Add(m.Value);
            }
            
        }
        private void LeaveGuildButton_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();

            //check that a player and guild has been selected
            if(Playerlistbox.SelectedIndex == -1)
            {
                outputBox.Text = "No player selected";
                return;
            }
            else
            {
                //parse the info
                string[] playerText = Playerlistbox.Text.Split('\t');
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
            if ((Playerlistbox.SelectedIndex == -1) && (guildListBox.SelectedIndex == -1))
            {
                outputBox.Text = "No player and guild selected";
                return;
            }
            else
            {
                //parse the info
                string[] playerText = Playerlistbox.Text.Split('\t');
                string[] guildText = guildListBox.Text.Split('\t');

                //parse the guild ID to a uint, not a string
                uint.TryParse(guildText[0], out guildID );

                //pass the player dictionary, player name, and guildID to function to join a guild
                player1.PlayerJoinGuild(playerDictionary, playerText[1], guildID);
                outputBox.Text = "Player successfully joined the guild!";
            }
        }

        private void filterGuildButton_Click(object sender, EventArgs e)
        {
            //if there is something entered into the search bar, then remove the guilds
            //that do not have that server name
            
        }
    }
}
