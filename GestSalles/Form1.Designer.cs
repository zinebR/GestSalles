namespace GestSalles
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.linkMachines = new System.Windows.Forms.LinkLabel();
            this.linkLogiciels = new System.Windows.Forms.LinkLabel();
            this.linkSalles = new System.Windows.Forms.LinkLabel();
            this.linkReseaux = new System.Windows.Forms.LinkLabel();
            this.linkReclamations = new System.Windows.Forms.LinkLabel();
            this.linkUsers = new System.Windows.Forms.LinkLabel();
            this.panelReseaux = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMachines = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSalles = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelLogiciels = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelReclamations = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelReseaux.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelSalles.SuspendLayout();
            this.panelLogiciels.SuspendLayout();
            this.panelReclamations.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.linkMachines);
            this.panelMenu.Controls.Add(this.linkLogiciels);
            this.panelMenu.Controls.Add(this.linkSalles);
            this.panelMenu.Controls.Add(this.linkReseaux);
            this.panelMenu.Controls.Add(this.linkReclamations);
            this.panelMenu.Controls.Add(this.linkUsers);
            this.panelMenu.Location = new System.Drawing.Point(28, 37);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 429);
            this.panelMenu.TabIndex = 0;
            // 
            // linkMachines
            // 
            this.linkMachines.AutoSize = true;
            this.linkMachines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMachines.Location = new System.Drawing.Point(16, 144);
            this.linkMachines.Name = "linkMachines";
            this.linkMachines.Size = new System.Drawing.Size(137, 20);
            this.linkMachines.TabIndex = 12;
            this.linkMachines.TabStop = true;
            this.linkMachines.Text = "Gestion Machines";
            this.linkMachines.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMachines_LinkClicked);
            // 
            // linkLogiciels
            // 
            this.linkLogiciels.AutoSize = true;
            this.linkLogiciels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogiciels.Location = new System.Drawing.Point(16, 199);
            this.linkLogiciels.Name = "linkLogiciels";
            this.linkLogiciels.Size = new System.Drawing.Size(130, 20);
            this.linkLogiciels.TabIndex = 11;
            this.linkLogiciels.TabStop = true;
            this.linkLogiciels.Text = "Gestion Logiciels";
            this.linkLogiciels.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogiciels_LinkClicked);
            // 
            // linkSalles
            // 
            this.linkSalles.AutoSize = true;
            this.linkSalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSalles.Location = new System.Drawing.Point(16, 85);
            this.linkSalles.Name = "linkSalles";
            this.linkSalles.Size = new System.Drawing.Size(142, 20);
            this.linkSalles.TabIndex = 10;
            this.linkSalles.TabStop = true;
            this.linkSalles.Text = "Gestion des Salles";
            this.linkSalles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSalles_LinkClicked);
            // 
            // linkReseaux
            // 
            this.linkReseaux.AutoSize = true;
            this.linkReseaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReseaux.Location = new System.Drawing.Point(16, 326);
            this.linkReseaux.Name = "linkReseaux";
            this.linkReseaux.Size = new System.Drawing.Size(132, 20);
            this.linkReseaux.TabIndex = 9;
            this.linkReseaux.TabStop = true;
            this.linkReseaux.Text = "Gestion Réseaux";
            this.linkReseaux.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReseaux_LinkClicked);
            // 
            // linkReclamations
            // 
            this.linkReclamations.AutoSize = true;
            this.linkReclamations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReclamations.Location = new System.Drawing.Point(17, 259);
            this.linkReclamations.Name = "linkReclamations";
            this.linkReclamations.Size = new System.Drawing.Size(175, 18);
            this.linkReclamations.TabIndex = 8;
            this.linkReclamations.TabStop = true;
            this.linkReclamations.Text = "Gestion de Réclamations";
            this.linkReclamations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReclamations_LinkClicked);
            // 
            // linkUsers
            // 
            this.linkUsers.AutoSize = true;
            this.linkUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUsers.Location = new System.Drawing.Point(16, 29);
            this.linkUsers.Name = "linkUsers";
            this.linkUsers.Size = new System.Drawing.Size(148, 20);
            this.linkUsers.TabIndex = 7;
            this.linkUsers.TabStop = true;
            this.linkUsers.Text = "Gestion Utilisateurs";
            this.linkUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelReseaux
            // 
            this.panelReseaux.Controls.Add(this.label4);
            this.panelReseaux.Controls.Add(this.label3);
            this.panelReseaux.Controls.Add(this.label2);
            this.panelReseaux.Controls.Add(this.label1);
            this.panelReseaux.Controls.Add(this.textBox3);
            this.panelReseaux.Controls.Add(this.textBox2);
            this.panelReseaux.Controls.Add(this.textBox1);
            this.panelReseaux.Location = new System.Drawing.Point(263, 37);
            this.panelReseaux.Name = "panelReseaux";
            this.panelReseaux.Size = new System.Drawing.Size(532, 429);
            this.panelReseaux.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gestion Réseaux";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "MDP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(347, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.label5);
            this.panelUsers.Location = new System.Drawing.Point(263, 37);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(532, 429);
            this.panelUsers.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gestion Utilisateurs";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // panelMachines
            // 
            this.panelMachines.Controls.Add(this.label6);
            this.panelMachines.Location = new System.Drawing.Point(263, 37);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(532, 429);
            this.panelMachines.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gestion Machines";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panelSalles
            // 
            this.panelSalles.Controls.Add(this.label7);
            this.panelSalles.Location = new System.Drawing.Point(263, 37);
            this.panelSalles.Name = "panelSalles";
            this.panelSalles.Size = new System.Drawing.Size(532, 429);
            this.panelSalles.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gestion des Salles";
            // 
            // panelLogiciels
            // 
            this.panelLogiciels.Controls.Add(this.label8);
            this.panelLogiciels.Location = new System.Drawing.Point(263, 37);
            this.panelLogiciels.Name = "panelLogiciels";
            this.panelLogiciels.Size = new System.Drawing.Size(532, 429);
            this.panelLogiciels.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gestion Logiciels";
            // 
            // panelReclamations
            // 
            this.panelReclamations.Controls.Add(this.label9);
            this.panelReclamations.Location = new System.Drawing.Point(263, 37);
            this.panelReclamations.Name = "panelReclamations";
            this.panelReclamations.Size = new System.Drawing.Size(532, 429);
            this.panelReclamations.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gestion Réclamations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 493);
            this.Controls.Add(this.panelReseaux);
            this.Controls.Add(this.panelReclamations);
            this.Controls.Add(this.panelLogiciels);
            this.Controls.Add(this.panelSalles);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelMachines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelReseaux.ResumeLayout(false);
            this.panelReseaux.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelMachines.ResumeLayout(false);
            this.panelMachines.PerformLayout();
            this.panelSalles.ResumeLayout(false);
            this.panelSalles.PerformLayout();
            this.panelLogiciels.ResumeLayout(false);
            this.panelLogiciels.PerformLayout();
            this.panelReclamations.ResumeLayout(false);
            this.panelReclamations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.LinkLabel linkMachines;
        private System.Windows.Forms.LinkLabel linkLogiciels;
        private System.Windows.Forms.LinkLabel linkSalles;
        private System.Windows.Forms.LinkLabel linkReseaux;
        private System.Windows.Forms.LinkLabel linkReclamations;
        private System.Windows.Forms.LinkLabel linkUsers;
        private System.Windows.Forms.Panel panelReseaux;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMachines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelSalles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelLogiciels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelReclamations;
        private System.Windows.Forms.Label label9;
    }
}

