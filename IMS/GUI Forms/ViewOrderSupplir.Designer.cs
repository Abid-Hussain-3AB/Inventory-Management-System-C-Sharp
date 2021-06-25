
namespace IMS.GUI_Forms
{
    partial class ViewOrderSupplir
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
            this.dgv_OrderSupplir = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderSupplir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OrderSupplir
            // 
            this.dgv_OrderSupplir.AllowUserToAddRows = false;
            this.dgv_OrderSupplir.AllowUserToDeleteRows = false;
            this.dgv_OrderSupplir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderSupplir.Location = new System.Drawing.Point(10, 10);
            this.dgv_OrderSupplir.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_OrderSupplir.Name = "dgv_OrderSupplir";
            this.dgv_OrderSupplir.ReadOnly = true;
            this.dgv_OrderSupplir.RowTemplate.Height = 40;
            this.dgv_OrderSupplir.Size = new System.Drawing.Size(780, 284);
            this.dgv_OrderSupplir.TabIndex = 1;
            this.dgv_OrderSupplir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OrderSupplir_CellContentClick);
            // 
            // ViewOrderSupplir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_OrderSupplir);
            this.Name = "ViewOrderSupplir";
            this.Text = "ViewOrderSupplir";
            this.Load += new System.EventHandler(this.ViewOrderSupplir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderSupplir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_OrderSupplir;
    }
}