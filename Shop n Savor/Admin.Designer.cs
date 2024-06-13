using System.Windows.Forms;

namespace Shop_n_Savor
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dgvemployees = new System.Windows.Forms.DataGridView();
            this.tbuname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tblname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.bupdate = new System.Windows.Forms.Button();
            this.bnew = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbyes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.logowhite = new System.Windows.Forms.PictureBox();
            this.logoblack = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.inputinfo = new System.Windows.Forms.Panel();
            this.bsave = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logowhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoblack)).BeginInit();
            this.inputinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvemployees
            // 
            this.dgvemployees.AllowUserToAddRows = false;
            this.dgvemployees.AllowUserToDeleteRows = false;
            this.dgvemployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemployees.Location = new System.Drawing.Point(12, 206);
            this.dgvemployees.Name = "dgvemployees";
            this.dgvemployees.ReadOnly = true;
            this.dgvemployees.RowHeadersWidth = 51;
            this.dgvemployees.RowTemplate.Height = 24;
            this.dgvemployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvemployees.Size = new System.Drawing.Size(1158, 180);
            this.dgvemployees.TabIndex = 0;
            this.dgvemployees.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemployees_CellEnter);
            // 
            // tbuname
            // 
            this.tbuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuname.Location = new System.Drawing.Point(3, 3);
            this.tbuname.Name = "tbuname";
            this.tbuname.Size = new System.Drawing.Size(452, 41);
            this.tbuname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // tbfname
            // 
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.Location = new System.Drawing.Point(3, 50);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(452, 41);
            this.tbfname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // tblname
            // 
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.Location = new System.Drawing.Point(3, 97);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(452, 41);
            this.tblname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // tbsearch
            // 
            this.tbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.Location = new System.Drawing.Point(141, 392);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(1029, 41);
            this.tbsearch.TabIndex = 7;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 709);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.Location = new System.Drawing.Point(3, 238);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(452, 41);
            this.tbemail.TabIndex = 11;
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "dd MMM yyyy";
            this.dtpdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(3, 191);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(452, 41);
            this.dtpdob.TabIndex = 13;
            this.dtpdob.Value = new System.DateTime(2022, 12, 24, 0, 0, 0, 0);
            // 
            // bupdate
            // 
            this.bupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bupdate.Location = new System.Drawing.Point(753, 794);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(417, 41);
            this.bupdate.TabIndex = 14;
            this.bupdate.Text = "Update Details";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bnew
            // 
            this.bnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bnew.Location = new System.Drawing.Point(753, 747);
            this.bnew.Name = "bnew";
            this.bnew.Size = new System.Drawing.Size(417, 41);
            this.bnew.TabIndex = 15;
            this.bnew.Text = "New Employee";
            this.bnew.UseVisualStyleBackColor = true;
            this.bnew.Click += new System.EventHandler(this.bnew_Click);
            // 
            // bdelete
            // 
            this.bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bdelete.Location = new System.Drawing.Point(753, 841);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(417, 41);
            this.bdelete.TabIndex = 16;
            this.bdelete.Text = "Delete Employee";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 756);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone:";
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(3, 285);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(452, 41);
            this.tbphone.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(13, 803);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 36);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address:";
            // 
            // tbaddress
            // 
            this.tbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.Location = new System.Drawing.Point(3, 332);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(452, 82);
            this.tbaddress.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 893);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 36);
            this.label9.TabIndex = 22;
            this.label9.Text = "Admin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(12, 938);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 36);
            this.label10.TabIndex = 24;
            this.label10.Text = "Password:";
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(3, 467);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(452, 41);
            this.tbpass.TabIndex = 23;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(3, 3);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(100, 40);
            this.rbmale.TabIndex = 25;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(139, 3);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(132, 40);
            this.rbfemale.TabIndex = 26;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbfemale);
            this.panel1.Controls.Add(this.rbmale);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 41);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbno);
            this.panel2.Controls.Add(this.rbyes);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 41);
            this.panel2.TabIndex = 28;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbno.Location = new System.Drawing.Point(139, 3);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(75, 40);
            this.rbno.TabIndex = 26;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbyes
            // 
            this.rbyes.AutoSize = true;
            this.rbyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbyes.Location = new System.Drawing.Point(3, 3);
            this.rbyes.Name = "rbyes";
            this.rbyes.Size = new System.Drawing.Size(87, 40);
            this.rbyes.TabIndex = 25;
            this.rbyes.TabStop = true;
            this.rbyes.Text = "Yes";
            this.rbyes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(11, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 36);
            this.label11.TabIndex = 29;
            this.label11.Text = "Search:";
            // 
            // logowhite
            // 
            this.logowhite.BackColor = System.Drawing.Color.Transparent;
            this.logowhite.Image = ((System.Drawing.Image)(resources.GetObject("logowhite.Image")));
            this.logowhite.Location = new System.Drawing.Point(13, 13);
            this.logowhite.Margin = new System.Windows.Forms.Padding(4);
            this.logowhite.Name = "logowhite";
            this.logowhite.Size = new System.Drawing.Size(291, 150);
            this.logowhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logowhite.TabIndex = 30;
            this.logowhite.TabStop = false;
            this.logowhite.Visible = false;
            // 
            // logoblack
            // 
            this.logoblack.BackColor = System.Drawing.Color.Transparent;
            this.logoblack.Image = ((System.Drawing.Image)(resources.GetObject("logoblack.Image")));
            this.logoblack.Location = new System.Drawing.Point(12, 13);
            this.logoblack.Margin = new System.Windows.Forms.Padding(4);
            this.logoblack.Name = "logoblack";
            this.logoblack.Size = new System.Drawing.Size(291, 150);
            this.logoblack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoblack.TabIndex = 31;
            this.logoblack.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(12, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 36);
            this.label12.TabIndex = 32;
            this.label12.Text = "List of Employees:";
            // 
            // inputinfo
            // 
            this.inputinfo.Controls.Add(this.tbpass);
            this.inputinfo.Controls.Add(this.tbuname);
            this.inputinfo.Controls.Add(this.tbfname);
            this.inputinfo.Controls.Add(this.tblname);
            this.inputinfo.Controls.Add(this.panel2);
            this.inputinfo.Controls.Add(this.tbemail);
            this.inputinfo.Controls.Add(this.panel1);
            this.inputinfo.Controls.Add(this.dtpdob);
            this.inputinfo.Controls.Add(this.tbphone);
            this.inputinfo.Controls.Add(this.tbaddress);
            this.inputinfo.Enabled = false;
            this.inputinfo.Location = new System.Drawing.Point(218, 468);
            this.inputinfo.Name = "inputinfo";
            this.inputinfo.Size = new System.Drawing.Size(476, 523);
            this.inputinfo.TabIndex = 33;
            // 
            // bsave
            // 
            this.bsave.Enabled = false;
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bsave.Location = new System.Drawing.Point(753, 888);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(200, 41);
            this.bsave.TabIndex = 34;
            this.bsave.Text = "Save";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bexit.Location = new System.Drawing.Point(753, 935);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(417, 41);
            this.bexit.TabIndex = 35;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bcancel
            // 
            this.bcancel.Enabled = false;
            this.bcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bcancel.Location = new System.Drawing.Point(970, 888);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(200, 41);
            this.bcancel.TabIndex = 36;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1013);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logoblack);
            this.Controls.Add(this.logowhite);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bnew);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvemployees);
            this.Controls.Add(this.inputinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logowhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoblack)).EndInit();
            this.inputinfo.ResumeLayout(false);
            this.inputinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvemployees;
        private System.Windows.Forms.TextBox tbuname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bnew;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbyes;
        private System.Windows.Forms.Label label11;
        private PictureBox logowhite;
        private PictureBox logoblack;
        private Label label12;
        private Panel inputinfo;
        private Button bsave;
        private Button bexit;
        private Button bcancel;
    }
}