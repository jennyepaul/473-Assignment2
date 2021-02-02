
namespace JennyCasey_Assign2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Playerlistbox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManagementFuncBox = new System.Windows.Forms.GroupBox();
            this.SearchGuild = new System.Windows.Forms.Label();
            this.SearchPlayer = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchPlayer_Textbox = new System.Windows.Forms.TextBox();
            this.SearchCriteriaButton = new System.Windows.Forms.Button();
            this.LeaveGuildButton = new System.Windows.Forms.Button();
            this.JoinGuildButton = new System.Windows.Forms.Button();
            this.DisbandGuildButton = new System.Windows.Forms.Button();
            this.GuildRosterButton = new System.Windows.Forms.Button();
            this.CreatePlayerBox = new System.Windows.Forms.GroupBox();
            this.CreateGuildBox = new System.Windows.Forms.GroupBox();
            this.ManagementFuncBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player/Guild Management System";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 518);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1189, 130);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            // 
            // Playerlistbox
            // 
            this.Playerlistbox.FormattingEnabled = true;
            this.Playerlistbox.ItemHeight = 16;
            this.Playerlistbox.Location = new System.Drawing.Point(681, 90);
            this.Playerlistbox.Name = "Playerlistbox";
            this.Playerlistbox.Size = new System.Drawing.Size(253, 388);
            this.Playerlistbox.TabIndex = 3;
            this.Playerlistbox.Click += new System.EventHandler(this.Playerlistbox_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(952, 92);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(262, 388);
            this.listBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(677, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(948, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guilds";
            // 
            // ManagementFuncBox
            // 
            this.ManagementFuncBox.Controls.Add(this.SearchGuild);
            this.ManagementFuncBox.Controls.Add(this.SearchPlayer);
            this.ManagementFuncBox.Controls.Add(this.textBox2);
            this.ManagementFuncBox.Controls.Add(this.SearchPlayer_Textbox);
            this.ManagementFuncBox.Controls.Add(this.SearchCriteriaButton);
            this.ManagementFuncBox.Controls.Add(this.LeaveGuildButton);
            this.ManagementFuncBox.Controls.Add(this.JoinGuildButton);
            this.ManagementFuncBox.Controls.Add(this.DisbandGuildButton);
            this.ManagementFuncBox.Controls.Add(this.GuildRosterButton);
            this.ManagementFuncBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementFuncBox.Location = new System.Drawing.Point(12, 56);
            this.ManagementFuncBox.Name = "ManagementFuncBox";
            this.ManagementFuncBox.Size = new System.Drawing.Size(633, 144);
            this.ManagementFuncBox.TabIndex = 7;
            this.ManagementFuncBox.TabStop = false;
            this.ManagementFuncBox.Text = "Management Functions";
            // 
            // SearchGuild
            // 
            this.SearchGuild.AutoSize = true;
            this.SearchGuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGuild.ForeColor = System.Drawing.Color.Black;
            this.SearchGuild.Location = new System.Drawing.Point(381, 93);
            this.SearchGuild.Name = "SearchGuild";
            this.SearchGuild.Size = new System.Drawing.Size(165, 17);
            this.SearchGuild.TabIndex = 8;
            this.SearchGuild.Text = "Search Guild (by Server)";
            // 
            // SearchPlayer
            // 
            this.SearchPlayer.AutoSize = true;
            this.SearchPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPlayer.ForeColor = System.Drawing.Color.Black;
            this.SearchPlayer.Location = new System.Drawing.Point(379, 22);
            this.SearchPlayer.Name = "SearchPlayer";
            this.SearchPlayer.Size = new System.Drawing.Size(167, 17);
            this.SearchPlayer.TabIndex = 7;
            this.SearchPlayer.Text = "Search Player (by Name)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 27);
            this.textBox2.TabIndex = 6;
            // 
            // SearchPlayer_Textbox
            // 
            this.SearchPlayer_Textbox.Location = new System.Drawing.Point(379, 45);
            this.SearchPlayer_Textbox.Name = "SearchPlayer_Textbox";
            this.SearchPlayer_Textbox.Size = new System.Drawing.Size(192, 27);
            this.SearchPlayer_Textbox.TabIndex = 5;
            // 
            // SearchCriteriaButton
            // 
            this.SearchCriteriaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCriteriaButton.ForeColor = System.Drawing.Color.Black;
            this.SearchCriteriaButton.Location = new System.Drawing.Point(159, 57);
            this.SearchCriteriaButton.Name = "SearchCriteriaButton";
            this.SearchCriteriaButton.Size = new System.Drawing.Size(160, 25);
            this.SearchCriteriaButton.TabIndex = 4;
            this.SearchCriteriaButton.Text = "Apply Search Criteria";
            this.SearchCriteriaButton.UseVisualStyleBackColor = true;
            this.SearchCriteriaButton.Click += new System.EventHandler(this.SearchCriteriaButton_Click);
            // 
            // LeaveGuildButton
            // 
            this.LeaveGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveGuildButton.ForeColor = System.Drawing.Color.Black;
            this.LeaveGuildButton.Location = new System.Drawing.Point(159, 26);
            this.LeaveGuildButton.Name = "LeaveGuildButton";
            this.LeaveGuildButton.Size = new System.Drawing.Size(160, 25);
            this.LeaveGuildButton.TabIndex = 3;
            this.LeaveGuildButton.Text = "Leave Guild";
            this.LeaveGuildButton.UseVisualStyleBackColor = true;
            // 
            // JoinGuildButton
            // 
            this.JoinGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinGuildButton.ForeColor = System.Drawing.Color.Black;
            this.JoinGuildButton.Location = new System.Drawing.Point(13, 88);
            this.JoinGuildButton.Name = "JoinGuildButton";
            this.JoinGuildButton.Size = new System.Drawing.Size(140, 26);
            this.JoinGuildButton.TabIndex = 2;
            this.JoinGuildButton.Text = "Join Guild";
            this.JoinGuildButton.UseVisualStyleBackColor = true;
            // 
            // DisbandGuildButton
            // 
            this.DisbandGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisbandGuildButton.ForeColor = System.Drawing.Color.Black;
            this.DisbandGuildButton.Location = new System.Drawing.Point(13, 57);
            this.DisbandGuildButton.Name = "DisbandGuildButton";
            this.DisbandGuildButton.Size = new System.Drawing.Size(140, 25);
            this.DisbandGuildButton.TabIndex = 1;
            this.DisbandGuildButton.Text = "Disband Guild";
            this.DisbandGuildButton.UseVisualStyleBackColor = true;
            // 
            // GuildRosterButton
            // 
            this.GuildRosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuildRosterButton.ForeColor = System.Drawing.Color.Black;
            this.GuildRosterButton.Location = new System.Drawing.Point(13, 26);
            this.GuildRosterButton.Name = "GuildRosterButton";
            this.GuildRosterButton.Size = new System.Drawing.Size(140, 25);
            this.GuildRosterButton.TabIndex = 0;
            this.GuildRosterButton.Text = "Print Guild Roster";
            this.GuildRosterButton.UseVisualStyleBackColor = true;
            // 
            // CreatePlayerBox
            // 
            this.CreatePlayerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayerBox.Location = new System.Drawing.Point(12, 206);
            this.CreatePlayerBox.Name = "CreatePlayerBox";
            this.CreatePlayerBox.Size = new System.Drawing.Size(633, 136);
            this.CreatePlayerBox.TabIndex = 8;
            this.CreatePlayerBox.TabStop = false;
            this.CreatePlayerBox.Text = "Create New Player";
            // 
            // CreateGuildBox
            // 
            this.CreateGuildBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGuildBox.Location = new System.Drawing.Point(12, 348);
            this.CreateGuildBox.Name = "CreateGuildBox";
            this.CreateGuildBox.Size = new System.Drawing.Size(633, 139);
            this.CreateGuildBox.TabIndex = 9;
            this.CreateGuildBox.TabStop = false;
            this.CreateGuildBox.Text = "Create New Guild";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 670);
            this.Controls.Add(this.CreateGuildBox);
            this.Controls.Add(this.CreatePlayerBox);
            this.Controls.Add(this.ManagementFuncBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Playerlistbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ManagementFuncBox.ResumeLayout(false);
            this.ManagementFuncBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Playerlistbox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox ManagementFuncBox;
        private System.Windows.Forms.GroupBox CreatePlayerBox;
        private System.Windows.Forms.GroupBox CreateGuildBox;
        private System.Windows.Forms.Button SearchCriteriaButton;
        private System.Windows.Forms.Button LeaveGuildButton;
        private System.Windows.Forms.Button JoinGuildButton;
        private System.Windows.Forms.Button DisbandGuildButton;
        private System.Windows.Forms.Button GuildRosterButton;
        private System.Windows.Forms.Label SearchPlayer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox SearchPlayer_Textbox;
        private System.Windows.Forms.Label SearchGuild;
    }
}

