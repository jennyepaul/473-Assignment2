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

        /*private void AddPlayer_Button_Click(object sender, EventArgs e)
        {

            if (this.Name_Textbox.Text != "") // && this.Role_Dropdown.SelectedIndex == -1)
            {
                string to_add = this.Name_Textbox.Text + "\t" + this.Role_Dropdown.SelectedItem;
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

        /*private void Load_DropBox_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();

            var players = player1.BuildPlayerDictionary();

            foreach (var i in players)
            {
                Role_Dropdown.Items.Add(i.Value.Race);
            }
        }*/
    }
}
