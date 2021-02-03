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
        public Form1()
        {
            InitializeComponent();

            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            Playerlistbox.Items.Clear();

            foreach (var i in players)
            {
                Playerlistbox.Items.Add(string.Format("{0} \t {1} \t {2}", i.Value.Name.PadRight(10), i.Value.Race, i.Value.Level));
            }
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

                if (!Role_Dropdown.Items.Contains(i.Value.Name))
                {
                    Role_Dropdown.Items.Add(i.Value.Name);
                }

                if (!Race_Dropdown.Items.Contains(i.Value.Race))
                {
                    Race_Dropdown.Items.Add(i.Value.Race);
                }

                if (!Class_Dropdown.Items.Contains(i.Value.Classes))
                {
                    Class_Dropdown.Items.Add(i.Value.Classes);
                }
            }
        }

        /*private void Playerlistbox_Click_1(object sender, EventArgs e)
        {
            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            Playerlistbox.Items.Clear();

            foreach (var i in players)
            {
                Playerlistbox.Items.Add(string.Format("{0} \t {1} \t {2}", i.Value.Name.PadRight(10), i.Value.Race, i.Value.Level));
            }
        }*/

        /*private void Role_Dropdown_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            foreach (var i in players)
            {
                if (!Role_Dropdown.Items.Contains(i.Value.Name))
                {
                    Role_Dropdown.Items.Add(i.Value.Name);
                }
            }
        }

        private void Race_Dropdown_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            foreach (var i in players)
            { 
               if(!Race_Dropdown.Items.Contains(i.Value.Race))
               {
                    Race_Dropdown.Items.Add(i.Value.Race);
               }
            }
        }

        private void Class_Dropdown_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            foreach (var i in players)
            {
                if (!Class_Dropdown.Items.Contains(i.Value.Classes))
                {
                    Class_Dropdown.Items.Add(i.Value.Classes);
                }
            }
        }*/

        private void AddPlayer_Button_Click(object sender, EventArgs e)
        {
            if (this.Name_Textbox.Text != "") // && this.Role_Dropdown.SelectedIndex == -1)
            {
                Player player1 = new Player();
                var players = player1.BuildPlayerDictionary();

                string to_add = this.Name_Textbox.Text + "\t" + this.Race_Dropdown.SelectedItem
                    + "\t" + "0";
                Playerlistbox.Items.Add(to_add);

                List<uint> lists = new List<uint>();

                Player new_player = new Player { ID = 12345678, Name = this.Name_Textbox.Text, Level = 1,
                    Classes = (Class)this.Class_Dropdown.SelectedItem, Race = (Race)this.Race_Dropdown.SelectedItem,
                    Exp = 1, GuildID = 0, Inventory = lists };

                players.Add(new_player.Key, new_player);

                foreach (var i in players)
                {
                    //Playerlistbox.Items.Add(string.Format("{0} \t {1} \t", i.Value.Race, i.Value.Name));
                    richTextBox1.Text += i.Value + "\n";
                }

                this.Name_Textbox.Focus();
                this.Name_Textbox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a Name and Role to add.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Name_Textbox.Focus();
            }
        }
   

       /* private void Playerlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Playerlistbox.SelectedItem.ToString());
        }*/
    }
}
