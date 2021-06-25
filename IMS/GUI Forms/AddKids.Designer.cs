
namespace IMS.GUI_Forms
{
    partial class AddKids
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Addkids = new System.Windows.Forms.Button();
            this.txt_kids_type = new System.Windows.Forms.TextBox();
            this.txt_kids_name = new System.Windows.Forms.TextBox();
            this.txt_kids_price = new System.Windows.Forms.TextBox();
            this.txt_kids_remaning = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kids_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remaining";
            // 
            // btn_Addkids
            // 
            this.btn_Addkids.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Addkids.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Addkids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addkids.ForeColor = System.Drawing.Color.White;
            this.btn_Addkids.Location = new System.Drawing.Point(104, 319);
            this.btn_Addkids.Name = "btn_Addkids";
            this.btn_Addkids.Size = new System.Drawing.Size(91, 39);
            this.btn_Addkids.TabIndex = 4;
            this.btn_Addkids.Text = "Add Items";
            this.btn_Addkids.UseVisualStyleBackColor = false;
            this.btn_Addkids.Click += new System.EventHandler(this.btn_Addkids_Click);
            // 
            // txt_kids_type
            // 
            this.txt_kids_type.Location = new System.Drawing.Point(65, 108);
            this.txt_kids_type.Name = "txt_kids_type";
            this.txt_kids_type.Size = new System.Drawing.Size(100, 20);
            this.txt_kids_type.TabIndex = 5;
            // 
            // txt_kids_name
            // 
            this.txt_kids_name.Location = new System.Drawing.Point(65, 161);
            this.txt_kids_name.Name = "txt_kids_name";
            this.txt_kids_name.Size = new System.Drawing.Size(100, 20);
            this.txt_kids_name.TabIndex = 6;
            // 
            // txt_kids_price
            // 
            this.txt_kids_price.Location = new System.Drawing.Point(65, 216);
            this.txt_kids_price.Name = "txt_kids_price";
            this.txt_kids_price.Size = new System.Drawing.Size(100, 20);
            this.txt_kids_price.TabIndex = 7;
            // 
            // txt_kids_remaning
            // 
            this.txt_kids_remaning.Location = new System.Drawing.Point(65, 275);
            this.txt_kids_remaning.Name = "txt_kids_remaning";
            this.txt_kids_remaning.Size = new System.Drawing.Size(100, 20);
            this.txt_kids_remaning.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // txt_kids_ID
            // 
            this.txt_kids_ID.Location = new System.Drawing.Point(65, 60);
            this.txt_kids_ID.Name = "txt_kids_ID";
            this.txt_kids_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_kids_ID.TabIndex = 12;
            // 
            // AddKids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(611, 381);
            this.Controls.Add(this.txt_kids_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_kids_remaning);
            this.Controls.Add(this.txt_kids_price);
            this.Controls.Add(this.txt_kids_name);
            this.Controls.Add(this.txt_kids_type);
            this.Controls.Add(this.btn_Addkids);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddKids";
            this.Text = "AddKids";
            this.Load += new System.EventHandler(this.AddKids_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Addkids;
        private System.Windows.Forms.TextBox txt_kids_type;
        private System.Windows.Forms.TextBox txt_kids_name;
        private System.Windows.Forms.TextBox txt_kids_price;
        private System.Windows.Forms.TextBox txt_kids_remaning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kids_ID;
    }
}