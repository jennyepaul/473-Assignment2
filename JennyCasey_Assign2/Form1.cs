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

        private void JoinGuildButton_Click(object sender, EventArgs e)
        {
            //make sure a player has been selected
            //make sure a guild has been selected
            //parse the two selectedItem strings to capture the name
            //info necessary to activate the assignment 1 code
            //call that function from assign1

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
    }
}
