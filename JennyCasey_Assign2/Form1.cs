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
        }


        /* private void Role_Dropdown_Click(object sender, EventArgs e)
         {
             Player player1 = new Player();
             var players = player1.BuildPlayerDictionary();

             foreach (var i in players)
             {
                 Role_Dropdown.Items.Add(i.Value.Name);
             }
         }

         private void Race_Dropdown_Click(object sender, EventArgs e)
         {
             Player player1 = new Player();
             var players = player1.BuildPlayerDictionary();

             foreach (var i in players)
             {
                 Race_Dropdown.Items.Add(i.Value.Race);
             }
         }

         private void Class_Dropdown_Click(object sender, EventArgs e)
         {
             Player player1 = new Player();
             var players = player1.BuildPlayerDictionary();

             foreach (var i in players)
             {
                 Class_Dropdown.Items.Add(i.Value.Classes);
             }
         }

         private void AddPlayer_Button_Click(object sender, EventArgs e)
         {
             if (this.Name_Textbox.Text != "") // && this.Role_Dropdown.SelectedIndex == -1)
             {
                 string to_add = this.Name_Textbox.Text + "\t" + this.Role_Dropdown.SelectedItem
                     + "\t" + "0";
                 listBox1.Items.Add(to_add);
                 this.Name_Textbox.Focus();
                 this.Name_Textbox.Clear();
             }
             else
             {
                 MessageBox.Show("Please enter a Name and Role to add.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Name_Textbox.Focus();
             }
         }*/

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

        private void Playerlistbox_Click_1(object sender, EventArgs e)
        {
            Player player1 = new Player();
            var players = player1.BuildPlayerDictionary();

            Playerlistbox.Items.Clear();

            foreach (var i in players)
            {
                Playerlistbox.Items.Add(string.Format("{0} \t {1} \t {2}", i.Value.Name.PadRight(10), i.Value.Race, i.Value.Level));
            }
        }
    }
}
