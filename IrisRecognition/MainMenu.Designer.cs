namespace IrisRecognition
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonViewLogFiles = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewLogFiles
            // 
            this.buttonViewLogFiles.Location = new System.Drawing.Point(273, 240);
            this.buttonViewLogFiles.Name = "buttonViewLogFiles";
            this.buttonViewLogFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonViewLogFiles.TabIndex = 5;
            this.buttonViewLogFiles.Text = "view log files";
            this.buttonViewLogFiles.UseVisualStyleBackColor = true;
            this.buttonViewLogFiles.Click += new System.EventHandler(this.buttonViewLogFiles_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(273, 211);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUser.TabIndex = 4;
            this.buttonDeleteUser.Text = "delete user";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(273, 182);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.Location = new System.Drawing.Point(273, 269);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonViewUsers.TabIndex = 6;
            this.buttonViewUsers.Text = "view users";
            this.buttonViewUsers.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 445);
            this.Controls.Add(this.buttonViewUsers);
            this.Controls.Add(this.buttonViewLogFiles);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Iris Authentication System - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewLogFiles;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonViewUsers;
    }
}