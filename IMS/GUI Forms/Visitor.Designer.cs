
namespace IMS.GUI_Forms
{
    partial class Visitor
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Food = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_Beauty = new System.Windows.Forms.DataGridView();
            this.Kids = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_Kids = new System.Windows.Forms.DataGridView();
            this.dgv_Gaming = new System.Windows.Forms.DataGridView();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Beauty)).BeginInit();
            this.Kids.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gaming)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage1.Controls.Add(this.dgv_Food);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Food";
            // 
            // dgv_Food
            // 
            this.dgv_Food.AllowUserToAddRows = false;
            this.dgv_Food.AllowUserToDeleteRows = false;
            this.dgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Food.Location = new System.Drawing.Point(103, 28);
            this.dgv_Food.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Food.Name = "dgv_Food";
            this.dgv_Food.ReadOnly = true;
            this.dgv_Food.RowTemplate.Height = 40;
            this.dgv_Food.Size = new System.Drawing.Size(547, 360);
            this.dgv_Food.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.Kids);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dgv_Beauty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Health & Beauty";
            // 
            // dgv_Beauty
            // 
            this.dgv_Beauty.AllowUserToAddRows = false;
            this.dgv_Beauty.AllowUserToDeleteRows = false;
            this.dgv_Beauty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Beauty.Location = new System.Drawing.Point(103, 89);
            this.dgv_Beauty.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Beauty.Name = "dgv_Beauty";
            this.dgv_Beauty.ReadOnly = true;
            this.dgv_Beauty.RowTemplate.Height = 40;
            this.dgv_Beauty.Size = new System.Drawing.Size(551, 258);
            this.dgv_Beauty.TabIndex = 0;
            // 
            // Kids
            // 
            this.Kids.BackColor = System.Drawing.Color.Green;
            this.Kids.Controls.Add(this.dgv_Kids);
            this.Kids.Location = new System.Drawing.Point(4, 22);
            this.Kids.Name = "Kids";
            this.Kids.Padding = new System.Windows.Forms.Padding(3);
            this.Kids.Size = new System.Drawing.Size(792, 424);
            this.Kids.TabIndex = 2;
            this.Kids.Text = "Kids";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Cyan;
            this.tabPage3.Controls.Add(this.dgv_Gaming);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Computing & Gaming";
            // 
            // dgv_Kids
            // 
            this.dgv_Kids.AllowUserToAddRows = false;
            this.dgv_Kids.AllowUserToDeleteRows = false;
            this.dgv_Kids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kids.Location = new System.Drawing.Point(127, 102);
            this.dgv_Kids.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Kids.Name = "dgv_Kids";
            this.dgv_Kids.ReadOnly = true;
            this.dgv_Kids.RowTemplate.Height = 40;
            this.dgv_Kids.Size = new System.Drawing.Size(534, 269);
            this.dgv_Kids.TabIndex = 1;
            // 
            // dgv_Gaming
            // 
            this.dgv_Gaming.AllowUserToAddRows = false;
            this.dgv_Gaming.AllowUserToDeleteRows = false;
            this.dgv_Gaming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gaming.Location = new System.Drawing.Point(157, 102);
            this.dgv_Gaming.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Gaming.Name = "dgv_Gaming";
            this.dgv_Gaming.ReadOnly = true;
            this.dgv_Gaming.RowTemplate.Height = 40;
            this.dgv_Gaming.Size = new System.Drawing.Size(520, 251);
            this.dgv_Gaming.TabIndex = 1;
            // 
            // Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Visitor";
            this.Text = "Visitor";
            this.Load += new System.EventHandler(this.Visitor_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Beauty)).EndInit();
            this.Kids.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gaming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_Food;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Beauty;
        private System.Windows.Forms.TabPage Kids;
        private System.Windows.Forms.DataGridView dgv_Kids;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_Gaming;
    }
}