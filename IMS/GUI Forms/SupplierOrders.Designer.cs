
namespace IMS.GUI_Forms
{
    partial class SupplierOrders
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
            this.dgv_SupplierOrders = new System.Windows.Forms.DataGridView();
            this.btn_AcceptOrder = new System.Windows.Forms.Button();
            this.btn_CancelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SupplierOrders
            // 
            this.dgv_SupplierOrders.AllowUserToAddRows = false;
            this.dgv_SupplierOrders.AllowUserToDeleteRows = false;
            this.dgv_SupplierOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SupplierOrders.Location = new System.Drawing.Point(57, 33);
            this.dgv_SupplierOrders.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_SupplierOrders.Name = "dgv_SupplierOrders";
            this.dgv_SupplierOrders.ReadOnly = true;
            this.dgv_SupplierOrders.RowTemplate.Height = 40;
            this.dgv_SupplierOrders.Size = new System.Drawing.Size(687, 290);
            this.dgv_SupplierOrders.TabIndex = 2;
            // 
            // btn_AcceptOrder
            // 
            this.btn_AcceptOrder.Location = new System.Drawing.Point(509, 355);
            this.btn_AcceptOrder.Name = "btn_AcceptOrder";
            this.btn_AcceptOrder.Size = new System.Drawing.Size(103, 29);
            this.btn_AcceptOrder.TabIndex = 3;
            this.btn_AcceptOrder.Text = "Accept Order";
            this.btn_AcceptOrder.UseVisualStyleBackColor = true;
            this.btn_AcceptOrder.Click += new System.EventHandler(this.btn_AcceptOrder_Click);
            // 
            // btn_CancelOrder
            // 
            this.btn_CancelOrder.Location = new System.Drawing.Point(618, 355);
            this.btn_CancelOrder.Name = "btn_CancelOrder";
            this.btn_CancelOrder.Size = new System.Drawing.Size(103, 29);
            this.btn_CancelOrder.TabIndex = 4;
            this.btn_CancelOrder.Text = "Cancel Order";
            this.btn_CancelOrder.UseVisualStyleBackColor = true;
            this.btn_CancelOrder.Click += new System.EventHandler(this.btn_CancelOrder_Click);
            // 
            // SupplierOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IMS.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CancelOrder);
            this.Controls.Add(this.btn_AcceptOrder);
            this.Controls.Add(this.dgv_SupplierOrders);
            this.Name = "SupplierOrders";
            this.Text = "SupplierOrders";
            this.Load += new System.EventHandler(this.SupplierOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SupplierOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SupplierOrders;
        private System.Windows.Forms.Button btn_AcceptOrder;
        private System.Windows.Forms.Button btn_CancelOrder;
    }
}