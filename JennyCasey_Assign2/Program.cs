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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JennyCasey_Assign2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
