
namespace IMS.GUI_Forms
{
    partial class Addgame
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
            this.btn_Add_game = new System.Windows.Forms.Button();
            this.txt_game_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_game_name = new System.Windows.Forms.TextBox();
            this.txt_game_comp = new System.Windows.Forms.TextBox();
            this.txt_game_rem = new System.Windows.Forms.TextBox();
            this.txt_game_ID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txt_game_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Add_game
            // 
            this.btn_Add_game.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_game.ForeColor = System.Drawing.Color.White;
            this.btn_Add_game.Location = new System.Drawing.Point(64, 362);
            this.btn_Add_game.Name = "btn_Add_game";
            this.btn_Add_game.Size = new System.Drawing.Size(98, 31);
            this.btn_Add_game.TabIndex = 0;
            this.btn_Add_game.Text = "Add items";
            this.btn_Add_game.UseVisualStyleBackColor = false;
            this.btn_Add_game.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_game_type
            // 
            this.txt_game_type.Location = new System.Drawing.Point(34, 91);
            this.txt_game_type.Name = "txt_game_type";
            this.txt_game_type.Size = new System.Drawing.Size(100, 20);
            this.txt_game_type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Remaining";
            // 
            // txt_game_name
            // 
            this.txt_game_name.Location = new System.Drawing.Point(34, 156);
            this.txt_game_name.Name = "txt_game_name";
            this.txt_game_name.Size = new System.Drawing.Size(100, 20);
            this.txt_game_name.TabIndex = 6;
            // 
            // txt_game_comp
            // 
            this.txt_game_comp.Location = new System.Drawing.Point(34, 267);
            this.txt_game_comp.Name = "txt_game_comp";
            this.txt_game_comp.Size = new System.Drawing.Size(100, 20);
            this.txt_game_comp.TabIndex = 7;
            // 
            // txt_game_rem
            // 
            this.txt_game_rem.Location = new System.Drawing.Point(34, 318);
            this.txt_game_rem.Name = "txt_game_rem";
            this.txt_game_rem.Size = new System.Drawing.Size(100, 20);
            this.txt_game_rem.TabIndex = 8;
            // 
            // txt_game_ID
            // 
            this.txt_game_ID.Location = new System.Drawing.Point(38, 36);
            this.txt_game_ID.Name = "txt_game_ID";
            this.txt_game_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_game_ID.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(35, 20);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // txt_game_price
            // 
            this.txt_game_price.Location = new System.Drawing.Point(34, 210);
            this.txt_game_price.Name = "txt_game_price";
            this.txt_game_price.Size = new System.Drawing.Size(100, 20);
            this.txt_game_price.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // Addgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(350, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_game_price);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_game_ID);
            this.Controls.Add(this.txt_game_rem);
            this.Controls.Add(this.txt_game_comp);
            this.Controls.Add(this.txt_game_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_game_type);
            this.Controls.Add(this.btn_Add_game);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Addgame";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Addgame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_game;
        private System.Windows.Forms.TextBox txt_game_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_game_name;
        private System.Windows.Forms.TextBox txt_game_comp;
        private System.Windows.Forms.TextBox txt_game_rem;
        private System.Windows.Forms.TextBox txt_game_ID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_game_price;
        private System.Windows.Forms.Label label5;
    }
}