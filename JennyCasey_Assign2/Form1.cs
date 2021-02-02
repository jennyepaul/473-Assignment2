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
        private Dictionary<uint, string> guildDictionary;
        List<Player> players = new List<Player>();
        List<string> guilds = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Player newplayer = new Player();
            playerDictionary = newplayer.BuildPlayerDictionary();
            guildDictionary = newplayer.BuildGuildDictionary();

        }

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
                players.Add(i.Value);
            }
            foreach(var m in guildDictionary)
            {
                guilds.Add(m.Value);
            }
            Playerlistbox.DataSource = players;
            guildListBox.DataSource = guilds;
            
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

        private void SearchPlayer_Textbox_TextChanged(object sender, EventArgs e)
        {
            outputBox.Text = " ";
            string playerName = SearchPlayer_Textbox.Text;

            foreach(var i in playerDictionary)
            {
                if(i.Value.Name == playerName)
                {
                    outputBox.Text = (i.Value.Name);                  
                }
            }
        }
    }
}
