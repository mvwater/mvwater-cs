namespace mvwater_netfw
{
    partial class dbEstablishConnection
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
            this.formServerType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formServerType
            // 
            this.formServerType.FormattingEnabled = true;
            this.formServerType.Items.AddRange(new object[] {
            "Microsoft SQL Server",
            "MySQL 5.x",
            "PostgreSQL",
            "Oracle SQL",
            "MongoDB"});
            this.formServerType.Location = new System.Drawing.Point(30, 70);
            this.formServerType.Name = "formServerType";
            this.formServerType.Size = new System.Drawing.Size(300, 21);
            this.formServerType.TabIndex = 1;
            this.formServerType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Name";
            // 
            // formServerName
            // 
            this.formServerName.Location = new System.Drawing.Point(30, 120);
            this.formServerName.Name = "formServerName";
            this.formServerName.Size = new System.Drawing.Size(300, 20);
            this.formServerName.TabIndex = 3;
            this.formServerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // formUsername
            // 
            this.formUsername.Location = new System.Drawing.Point(30, 170);
            this.formUsername.Name = "formUsername";
            this.formUsername.Size = new System.Drawing.Size(140, 20);
            this.formUsername.TabIndex = 5;
            this.formUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // formPassword
            // 
            this.formPassword.Location = new System.Drawing.Point(30, 220);
            this.formPassword.Name = "formPassword";
            this.formPassword.PasswordChar = '*';
            this.formPassword.Size = new System.Drawing.Size(140, 20);
            this.formPassword.TabIndex = 7;
            this.formPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(120, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connect to Database";
            // 
            // dbEstablishConnection
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(365, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formServerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formServerType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dbEstablishConnection";
            this.Text = "MVAD - Establish Database Connection";
            this.Load += new System.EventHandler(this.dbEstablishConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formServerType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox formServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}