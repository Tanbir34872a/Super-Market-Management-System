using System.Windows.Forms;

namespace Shop_n_Savor
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.logowhite = new System.Windows.Forms.PictureBox();
            this.logoblack = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bexit = new System.Windows.Forms.Button();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbquant = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.Label();
            this.tbcomp = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.Label();
            this.tbpid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logowhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoblack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvproducts
            // 
            this.dgvproducts.AllowUserToAddRows = false;
            this.dgvproducts.AllowUserToDeleteRows = false;
            this.dgvproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Location = new System.Drawing.Point(12, 206);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.RowHeadersWidth = 51;
            this.dgvproducts.RowTemplate.Height = 24;
            this.dgvproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducts.Size = new System.Drawing.Size(619, 396);
            this.dgvproducts.TabIndex = 0;
            this.dgvproducts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducts_CellEnter);
            // 
            // tbsearch
            // 
            this.tbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.Location = new System.Drawing.Point(141, 608);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(490, 41);
            this.tbsearch.TabIndex = 7;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(11, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 36);
            this.label11.TabIndex = 29;
            this.label11.Text = "Search:";
            // 
            // logowhite
            // 
            this.logowhite.BackColor = System.Drawing.Color.Transparent;
            this.logowhite.Image = ((System.Drawing.Image)(resources.GetObject("logowhite.Image")));
            this.logowhite.InitialImage = ((System.Drawing.Image)(resources.GetObject("logowhite.InitialImage")));
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
            this.logoblack.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoblack.InitialImage")));
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
            this.label12.Size = new System.Drawing.Size(247, 36);
            this.label12.TabIndex = 32;
            this.label12.Text = "List of Products:";
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bexit.Location = new System.Drawing.Point(619, 293);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(532, 50);
            this.bexit.TabIndex = 35;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // productPic
            // 
            this.productPic.BackColor = System.Drawing.Color.Transparent;
            this.productPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("productPic.InitialImage")));
            this.productPic.Location = new System.Drawing.Point(638, 206);
            this.productPic.Margin = new System.Windows.Forms.Padding(4);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(531, 396);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 37;
            this.productPic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 36);
            this.label5.TabIndex = 42;
            this.label5.Text = "In Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 41;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "Product ID:";
            // 
            // tbquant
            // 
            this.tbquant.AutoSize = true;
            this.tbquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbquant.Location = new System.Drawing.Point(149, 300);
            this.tbquant.Name = "tbquant";
            this.tbquant.Size = new System.Drawing.Size(140, 36);
            this.tbquant.TabIndex = 53;
            this.tbquant.Text = "In Stock:";
            // 
            // tbprice
            // 
            this.tbprice.AutoSize = true;
            this.tbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbprice.Location = new System.Drawing.Point(106, 244);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(97, 36);
            this.tbprice.TabIndex = 52;
            this.tbprice.Text = "Price:";
            // 
            // tbcomp
            // 
            this.tbcomp.AutoSize = true;
            this.tbcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbcomp.Location = new System.Drawing.Point(166, 188);
            this.tbcomp.Name = "tbcomp";
            this.tbcomp.Size = new System.Drawing.Size(157, 36);
            this.tbcomp.TabIndex = 51;
            this.tbcomp.Text = "Company:";
            // 
            // tbname
            // 
            this.tbname.AutoSize = true;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbname.Location = new System.Drawing.Point(114, 132);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(105, 36);
            this.tbname.TabIndex = 50;
            this.tbname.Text = "Name:";
            // 
            // tbpid
            // 
            this.tbpid.AutoSize = true;
            this.tbpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tbpid.Location = new System.Drawing.Point(184, 76);
            this.tbpid.Name = "tbpid";
            this.tbpid.Size = new System.Drawing.Size(175, 36);
            this.tbpid.TabIndex = 49;
            this.tbpid.Text = "Product ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "Product Details:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(638, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 50);
            this.button1.TabIndex = 55;
            this.button1.Text = "◀◀️";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(769, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 50);
            this.button2.TabIndex = 56;
            this.button2.Text = "◀️";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(914, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 50);
            this.button3.TabIndex = 57;
            this.button3.Text = "▶️";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(1045, 604);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 50);
            this.button4.TabIndex = 58;
            this.button4.Text = "▶️▶️";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(636, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 174);
            this.panel1.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(151, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(383, 36);
            this.label7.TabIndex = 59;
            this.label7.Text = "Welcome, Dear Customer!";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(480, 120);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 62;
            this.button6.Text = "🌙";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(636, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 174);
            this.panel2.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(151, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(383, 36);
            this.label8.TabIndex = 59;
            this.label8.Text = "Welcome, Dear Customer!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.bexit);
            this.panel3.Controls.Add(this.tbquant);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbpid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbname);
            this.panel3.Controls.Add(this.tbcomp);
            this.panel3.Controls.Add(this.tbprice);
            this.panel3.Location = new System.Drawing.Point(12, 655);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 346);
            this.panel3.TabIndex = 62;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1182, 1013);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productPic);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logoblack);
            this.Controls.Add(this.logowhite);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.dgvproducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logowhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoblack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label11;
        private PictureBox logowhite;
        private PictureBox logoblack;
        private Label label12;
        private Button bexit;
        private PictureBox productPic;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label tbquant;
        private Label tbprice;
        private Label tbcomp;
        private Label tbname;
        private Label tbpid;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Button button6;
        private Label label8;
        private Panel panel3;
    }
}