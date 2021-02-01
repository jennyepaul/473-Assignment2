
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchPlayer = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchCriteriaButton = new System.Windows.Forms.Button();
            this.LeaveGuildButton = new System.Windows.Forms.Button();
            this.JoinGuildButton = new System.Windows.Forms.Button();
            this.DisbandGuildButton = new System.Windows.Forms.Button();
            this.GuildRosterButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchGuild = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(681, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 388);
            this.listBox1.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchGuild);
            this.groupBox1.Controls.Add(this.SearchPlayer);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.SearchCriteriaButton);
            this.groupBox1.Controls.Add(this.LeaveGuildButton);
            this.groupBox1.Controls.Add(this.JoinGuildButton);
            this.groupBox1.Controls.Add(this.DisbandGuildButton);
            this.groupBox1.Controls.Add(this.GuildRosterButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management Functions";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 27);
            this.textBox1.TabIndex = 5;
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
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 136);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Player";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 139);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New Guild";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 670);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SearchCriteriaButton;
        private System.Windows.Forms.Button LeaveGuildButton;
        private System.Windows.Forms.Button JoinGuildButton;
        private System.Windows.Forms.Button DisbandGuildButton;
        private System.Windows.Forms.Button GuildRosterButton;
        private System.Windows.Forms.Label SearchPlayer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchGuild;
    }
}

