
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
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.guildListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManagementFuncBox = new System.Windows.Forms.GroupBox();
            this.clearSearchCriteria = new System.Windows.Forms.Button();
            this.SearchCriteriaButton = new System.Windows.Forms.Button();
            this.SearchGuild = new System.Windows.Forms.Label();
            this.SearchPlayer = new System.Windows.Forms.Label();
            this.searchGuildTextBox = new System.Windows.Forms.TextBox();
            this.searchPlayerTextbox = new System.Windows.Forms.TextBox();
            this.LeaveGuildButton = new System.Windows.Forms.Button();
            this.JoinGuildButton = new System.Windows.Forms.Button();
            this.DisbandGuildButton = new System.Windows.Forms.Button();
            this.GuildRosterButton = new System.Windows.Forms.Button();
            this.CreatePlayerBox = new System.Windows.Forms.GroupBox();
            this.CreateGuildBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Class_Dropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Race_Dropdown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Role_Dropdown = new System.Windows.Forms.ComboBox();
            this.AddPlayer_Button = new System.Windows.Forms.Button();
            this.ManagementFuncBox.SuspendLayout();
            this.CreatePlayerBox.SuspendLayout();
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
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 518);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1294, 159);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
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
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 16;
            this.playerListBox.Location = new System.Drawing.Point(661, 82);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(284, 388);
            this.playerListBox.TabIndex = 3;
            this.playerListBox.DoubleClick += new System.EventHandler(this.playerListBox_DoubleClick);
            // 
            // guildListBox
            // 
            this.guildListBox.FormattingEnabled = true;
            this.guildListBox.ItemHeight = 16;
            this.guildListBox.Location = new System.Drawing.Point(978, 79);
            this.guildListBox.Name = "guildListBox";
            this.guildListBox.Size = new System.Drawing.Size(328, 388);
            this.guildListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(657, 56);
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
            this.label4.Location = new System.Drawing.Point(974, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guilds";
            // 
            // ManagementFuncBox
            // 
            this.ManagementFuncBox.Controls.Add(this.clearSearchCriteria);
            this.ManagementFuncBox.Controls.Add(this.SearchCriteriaButton);
            this.ManagementFuncBox.Controls.Add(this.SearchGuild);
            this.ManagementFuncBox.Controls.Add(this.SearchPlayer);
            this.ManagementFuncBox.Controls.Add(this.searchGuildTextBox);
            this.ManagementFuncBox.Controls.Add(this.searchPlayerTextbox);
            this.ManagementFuncBox.Controls.Add(this.LeaveGuildButton);
            this.ManagementFuncBox.Controls.Add(this.JoinGuildButton);
            this.ManagementFuncBox.Controls.Add(this.DisbandGuildButton);
            this.ManagementFuncBox.Controls.Add(this.GuildRosterButton);
            this.ManagementFuncBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementFuncBox.Location = new System.Drawing.Point(12, 44);
            this.ManagementFuncBox.Name = "ManagementFuncBox";
            this.ManagementFuncBox.Size = new System.Drawing.Size(633, 156);
            this.ManagementFuncBox.TabIndex = 7;
            this.ManagementFuncBox.TabStop = false;
            this.ManagementFuncBox.Text = "Management Functions";
            // 
            // clearSearchCriteria
            // 
            this.clearSearchCriteria.BackColor = System.Drawing.SystemColors.Control;
            this.clearSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchCriteria.ForeColor = System.Drawing.Color.Black;
            this.clearSearchCriteria.Location = new System.Drawing.Point(384, 76);
            this.clearSearchCriteria.Name = "clearSearchCriteria";
            this.clearSearchCriteria.Size = new System.Drawing.Size(160, 29);
            this.clearSearchCriteria.TabIndex = 9;
            this.clearSearchCriteria.Text = "Clear Search Critera";
            this.clearSearchCriteria.UseVisualStyleBackColor = false;
            this.clearSearchCriteria.Click += new System.EventHandler(this.clearSearchCriteria_Click);
            // 
            // SearchCriteriaButton
            // 
            this.SearchCriteriaButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchCriteriaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCriteriaButton.ForeColor = System.Drawing.Color.Black;
            this.SearchCriteriaButton.Location = new System.Drawing.Point(384, 44);
            this.SearchCriteriaButton.Name = "SearchCriteriaButton";
            this.SearchCriteriaButton.Size = new System.Drawing.Size(160, 25);
            this.SearchCriteriaButton.TabIndex = 4;
            this.SearchCriteriaButton.Text = "Apply Search Criteria";
            this.SearchCriteriaButton.UseVisualStyleBackColor = false;
            this.SearchCriteriaButton.Click += new System.EventHandler(this.SearchCriteriaButton_Click);
            // 
            // SearchGuild
            // 
            this.SearchGuild.AutoSize = true;
            this.SearchGuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGuild.ForeColor = System.Drawing.Color.Black;
            this.SearchGuild.Location = new System.Drawing.Point(171, 88);
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
            this.SearchPlayer.Location = new System.Drawing.Point(169, 23);
            this.SearchPlayer.Name = "SearchPlayer";
            this.SearchPlayer.Size = new System.Drawing.Size(167, 17);
            this.SearchPlayer.TabIndex = 7;
            this.SearchPlayer.Text = "Search Player (by Name)";
            // 
            // searchGuildTextBox
            // 
            this.searchGuildTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGuildTextBox.Location = new System.Drawing.Point(172, 108);
            this.searchGuildTextBox.Name = "searchGuildTextBox";
            this.searchGuildTextBox.Size = new System.Drawing.Size(192, 27);
            this.searchGuildTextBox.TabIndex = 6;
            // 
            // searchPlayerTextbox
            // 
            this.searchPlayerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPlayerTextbox.Location = new System.Drawing.Point(172, 42);
            this.searchPlayerTextbox.Name = "searchPlayerTextbox";
            this.searchPlayerTextbox.Size = new System.Drawing.Size(192, 27);
            this.searchPlayerTextbox.TabIndex = 5;
            // 
            // LeaveGuildButton
            // 
            this.LeaveGuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveGuildButton.ForeColor = System.Drawing.Color.Black;
            this.LeaveGuildButton.Location = new System.Drawing.Point(13, 120);
            this.LeaveGuildButton.Name = "LeaveGuildButton";
            this.LeaveGuildButton.Size = new System.Drawing.Size(140, 25);
            this.LeaveGuildButton.TabIndex = 3;
            this.LeaveGuildButton.Text = "Leave Guild";
            this.LeaveGuildButton.UseVisualStyleBackColor = true;
            this.LeaveGuildButton.Click += new System.EventHandler(this.LeaveGuildButton_Click);
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
            this.JoinGuildButton.Click += new System.EventHandler(this.JoinGuildButton_Click);
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
            this.DisbandGuildButton.Click += new System.EventHandler(this.DisbandGuildButton_Click);
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
            this.GuildRosterButton.Click += new System.EventHandler(this.GuildRosterButton_Click);
            // 
            // CreatePlayerBox
            // 
            this.CreatePlayerBox.Controls.Add(this.AddPlayer_Button);
            this.CreatePlayerBox.Controls.Add(this.Role_Dropdown);
            this.CreatePlayerBox.Controls.Add(this.label8);
            this.CreatePlayerBox.Controls.Add(this.Race_Dropdown);
            this.CreatePlayerBox.Controls.Add(this.label7);
            this.CreatePlayerBox.Controls.Add(this.Class_Dropdown);
            this.CreatePlayerBox.Controls.Add(this.label6);
            this.CreatePlayerBox.Controls.Add(this.Name_Textbox);
            this.CreatePlayerBox.Controls.Add(this.label5);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player Name ";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Textbox.Location = new System.Drawing.Point(13, 43);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(192, 27);
            this.Name_Textbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Class";
            // 
            // Class_Dropdown
            // 
            this.Class_Dropdown.FormattingEnabled = true;
            this.Class_Dropdown.Location = new System.Drawing.Point(13, 93);
            this.Class_Dropdown.Name = "Class_Dropdown";
            this.Class_Dropdown.Size = new System.Drawing.Size(192, 28);
            this.Class_Dropdown.TabIndex = 12;
            this.Class_Dropdown.SelectedValueChanged += new System.EventHandler(this.Class_Dropdown_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(248, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Race";
            // 
            // Race_Dropdown
            // 
            this.Race_Dropdown.FormattingEnabled = true;
            this.Race_Dropdown.Location = new System.Drawing.Point(251, 43);
            this.Race_Dropdown.Name = "Race_Dropdown";
            this.Race_Dropdown.Size = new System.Drawing.Size(192, 28);
            this.Race_Dropdown.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(248, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Role";
            // 
            // Role_Dropdown
            // 
            this.Role_Dropdown.FormattingEnabled = true;
            this.Role_Dropdown.Location = new System.Drawing.Point(251, 93);
            this.Role_Dropdown.Name = "Role_Dropdown";
            this.Role_Dropdown.Size = new System.Drawing.Size(192, 28);
            this.Role_Dropdown.TabIndex = 16;
            // 
            // AddPlayer_Button
            // 
            this.AddPlayer_Button.BackColor = System.Drawing.SystemColors.Control;
            this.AddPlayer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayer_Button.ForeColor = System.Drawing.Color.Black;
            this.AddPlayer_Button.Location = new System.Drawing.Point(482, 42);
            this.AddPlayer_Button.Name = "AddPlayer_Button";
            this.AddPlayer_Button.Size = new System.Drawing.Size(94, 29);
            this.AddPlayer_Button.TabIndex = 17;
            this.AddPlayer_Button.Text = "Add Player";
            this.AddPlayer_Button.UseVisualStyleBackColor = false;
            this.AddPlayer_Button.Click += new System.EventHandler(this.AddPlayer_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1320, 689);
            this.Controls.Add(this.CreateGuildBox);
            this.Controls.Add(this.CreatePlayerBox);
            this.Controls.Add(this.ManagementFuncBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guildListBox);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ManagementFuncBox.ResumeLayout(false);
            this.ManagementFuncBox.PerformLayout();
            this.CreatePlayerBox.ResumeLayout(false);
            this.CreatePlayerBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ListBox guildListBox;
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
        private System.Windows.Forms.Label SearchGuild;
        private System.Windows.Forms.TextBox searchGuildTextBox;
        private System.Windows.Forms.TextBox searchPlayerTextbox;
        private System.Windows.Forms.Button clearSearchCriteria;
        private System.Windows.Forms.Button AddPlayer_Button;
        private System.Windows.Forms.ComboBox Role_Dropdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Race_Dropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Class_Dropdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label label5;
    }
}

