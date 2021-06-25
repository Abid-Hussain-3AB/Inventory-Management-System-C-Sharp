
namespace IMS.GUI_Forms
{
    partial class OrderSupplir
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
            this.text_Name = new System.Windows.Forms.TextBox();
            this.btn_Order = new System.Windows.Forms.Button();
            this.text_Company = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(163, 56);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(205, 20);
            this.text_Name.TabIndex = 1;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(202, 267);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(81, 34);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // text_Company
            // 
            this.text_Company.Location = new System.Drawing.Point(163, 118);
            this.text_Company.Name = "text_Company";
            this.text_Company.Size = new System.Drawing.Size(205, 20);
            this.text_Company.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company:";
            // 
            // text_Quantity
            // 
            this.text_Quantity.Location = new System.Drawing.Point(163, 197);
            this.text_Quantity.Name = "text_Quantity";
            this.text_Quantity.Size = new System.Drawing.Size(205, 20);
            this.text_Quantity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(55, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(293, 267);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 34);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // OrderSupplir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 396);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.text_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.label1);
            this.Name = "OrderSupplir";
            this.Text = "OrderSupplir";
            this.Load += new System.EventHandler(this.OrderSupplir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.TextBox text_Company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
    }
}