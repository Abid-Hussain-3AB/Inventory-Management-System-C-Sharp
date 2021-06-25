
namespace IMS.GUI_Forms
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_OrderView = new System.Windows.Forms.Button();
            this.btn_OrderItem = new System.Windows.Forms.Button();
            this.btn_badd = new System.Windows.Forms.Button();
            this.btn_Del_Beauty = new System.Windows.Forms.Button();
            this.dgv_Beauty_Emp = new System.Windows.Forms.DataGridView();
            this.Kids = new System.Windows.Forms.TabPage();
            this.btn_ViewOrd = new System.Windows.Forms.Button();
            this.btn_order_Item = new System.Windows.Forms.Button();
            this.btn_kadd = new System.Windows.Forms.Button();
            this.btn_Del_K = new System.Windows.Forms.Button();
            this.dgv_Kids_Emp = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Order_Com = new System.Windows.Forms.Button();
            this.btn_Add_Computing = new System.Windows.Forms.Button();
            this.btn_Del_Comp = new System.Windows.Forms.Button();
            this.dgv_Gaming_Emp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ViewOrder = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del_Food = new System.Windows.Forms.Button();
            this.dgv_Food_Emp = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Beauty_Emp)).BeginInit();
            this.Kids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kids_Emp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gaming_Emp)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food_Emp)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage2.Controls.Add(this.btn_OrderView);
            this.tabPage2.Controls.Add(this.btn_OrderItem);
            this.tabPage2.Controls.Add(this.btn_badd);
            this.tabPage2.Controls.Add(this.btn_Del_Beauty);
            this.tabPage2.Controls.Add(this.dgv_Beauty_Emp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Health & Beauty";
            // 
            // btn_OrderView
            // 
            this.btn_OrderView.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_OrderView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrderView.ForeColor = System.Drawing.Color.White;
            this.btn_OrderView.Location = new System.Drawing.Point(122, 351);
            this.btn_OrderView.Name = "btn_OrderView";
            this.btn_OrderView.Size = new System.Drawing.Size(104, 41);
            this.btn_OrderView.TabIndex = 5;
            this.btn_OrderView.Text = "View Order";
            this.btn_OrderView.UseVisualStyleBackColor = false;
            this.btn_OrderView.Click += new System.EventHandler(this.btn_OrderView_Click);
            // 
            // btn_OrderItem
            // 
            this.btn_OrderItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_OrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrderItem.ForeColor = System.Drawing.Color.White;
            this.btn_OrderItem.Location = new System.Drawing.Point(232, 351);
            this.btn_OrderItem.Name = "btn_OrderItem";
            this.btn_OrderItem.Size = new System.Drawing.Size(104, 41);
            this.btn_OrderItem.TabIndex = 4;
            this.btn_OrderItem.Text = "Order Item";
            this.btn_OrderItem.UseVisualStyleBackColor = false;
            this.btn_OrderItem.Click += new System.EventHandler(this.btn_OrderItem_Click);
            // 
            // btn_badd
            // 
            this.btn_badd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_badd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_badd.Location = new System.Drawing.Point(434, 351);
            this.btn_badd.Name = "btn_badd";
            this.btn_badd.Size = new System.Drawing.Size(104, 41);
            this.btn_badd.TabIndex = 3;
            this.btn_badd.Text = "Add item";
            this.btn_badd.UseVisualStyleBackColor = false;
            this.btn_badd.Click += new System.EventHandler(this.btn_badd_Click);
            // 
            // btn_Del_Beauty
            // 
            this.btn_Del_Beauty.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Del_Beauty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Beauty.Location = new System.Drawing.Point(544, 351);
            this.btn_Del_Beauty.Name = "btn_Del_Beauty";
            this.btn_Del_Beauty.Size = new System.Drawing.Size(110, 41);
            this.btn_Del_Beauty.TabIndex = 2;
            this.btn_Del_Beauty.Text = "Remove Item";
            this.btn_Del_Beauty.UseVisualStyleBackColor = false;
            this.btn_Del_Beauty.Click += new System.EventHandler(this.btn_Del_Beauty_Click);
            // 
            // dgv_Beauty_Emp
            // 
            this.dgv_Beauty_Emp.AllowUserToAddRows = false;
            this.dgv_Beauty_Emp.AllowUserToDeleteRows = false;
            this.dgv_Beauty_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Beauty_Emp.Location = new System.Drawing.Point(103, 89);
            this.dgv_Beauty_Emp.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Beauty_Emp.Name = "dgv_Beauty_Emp";
            this.dgv_Beauty_Emp.ReadOnly = true;
            this.dgv_Beauty_Emp.RowTemplate.Height = 40;
            this.dgv_Beauty_Emp.Size = new System.Drawing.Size(551, 258);
            this.dgv_Beauty_Emp.TabIndex = 0;
            this.dgv_Beauty_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Beauty_Emp_CellContentClick);
            // 
            // Kids
            // 
            this.Kids.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Kids.Controls.Add(this.btn_ViewOrd);
            this.Kids.Controls.Add(this.btn_order_Item);
            this.Kids.Controls.Add(this.btn_kadd);
            this.Kids.Controls.Add(this.btn_Del_K);
            this.Kids.Controls.Add(this.dgv_Kids_Emp);
            this.Kids.Location = new System.Drawing.Point(4, 22);
            this.Kids.Name = "Kids";
            this.Kids.Padding = new System.Windows.Forms.Padding(3);
            this.Kids.Size = new System.Drawing.Size(792, 424);
            this.Kids.TabIndex = 2;
            this.Kids.Text = "Kids";
            // 
            // btn_ViewOrd
            // 
            this.btn_ViewOrd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_ViewOrd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewOrd.ForeColor = System.Drawing.Color.White;
            this.btn_ViewOrd.Location = new System.Drawing.Point(165, 330);
            this.btn_ViewOrd.Name = "btn_ViewOrd";
            this.btn_ViewOrd.Size = new System.Drawing.Size(105, 40);
            this.btn_ViewOrd.TabIndex = 5;
            this.btn_ViewOrd.Text = "View Order";
            this.btn_ViewOrd.UseVisualStyleBackColor = false;
            this.btn_ViewOrd.Click += new System.EventHandler(this.btn_ViewOrd_Click);
            // 
            // btn_order_Item
            // 
            this.btn_order_Item.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_order_Item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_order_Item.ForeColor = System.Drawing.Color.White;
            this.btn_order_Item.Location = new System.Drawing.Point(276, 330);
            this.btn_order_Item.Name = "btn_order_Item";
            this.btn_order_Item.Size = new System.Drawing.Size(105, 40);
            this.btn_order_Item.TabIndex = 4;
            this.btn_order_Item.Text = "Order Item";
            this.btn_order_Item.UseVisualStyleBackColor = false;
            this.btn_order_Item.Click += new System.EventHandler(this.btn_order_Item_Click);
            // 
            // btn_kadd
            // 
            this.btn_kadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kadd.ForeColor = System.Drawing.Color.Yellow;
            this.btn_kadd.Location = new System.Drawing.Point(440, 331);
            this.btn_kadd.Name = "btn_kadd";
            this.btn_kadd.Size = new System.Drawing.Size(105, 40);
            this.btn_kadd.TabIndex = 3;
            this.btn_kadd.Text = "Add Items";
            this.btn_kadd.UseVisualStyleBackColor = true;
            this.btn_kadd.Click += new System.EventHandler(this.btn_kadd_Click);
            // 
            // btn_Del_K
            // 
            this.btn_Del_K.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del_K.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Del_K.Location = new System.Drawing.Point(551, 330);
            this.btn_Del_K.Name = "btn_Del_K";
            this.btn_Del_K.Size = new System.Drawing.Size(110, 41);
            this.btn_Del_K.TabIndex = 2;
            this.btn_Del_K.Text = "Remove Item";
            this.btn_Del_K.UseVisualStyleBackColor = true;
            this.btn_Del_K.Click += new System.EventHandler(this.btn_Del_K_Click);
            // 
            // dgv_Kids_Emp
            // 
            this.dgv_Kids_Emp.AllowUserToAddRows = false;
            this.dgv_Kids_Emp.AllowUserToDeleteRows = false;
            this.dgv_Kids_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kids_Emp.Location = new System.Drawing.Point(127, 102);
            this.dgv_Kids_Emp.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Kids_Emp.Name = "dgv_Kids_Emp";
            this.dgv_Kids_Emp.ReadOnly = true;
            this.dgv_Kids_Emp.RowTemplate.Height = 40;
            this.dgv_Kids_Emp.Size = new System.Drawing.Size(534, 224);
            this.dgv_Kids_Emp.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.btn_View);
            this.tabPage3.Controls.Add(this.btn_Order_Com);
            this.tabPage3.Controls.Add(this.btn_Add_Computing);
            this.tabPage3.Controls.Add(this.btn_Del_Comp);
            this.tabPage3.Controls.Add(this.dgv_Gaming_Emp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Computing & Gaming";
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_View.Location = new System.Drawing.Point(150, 330);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(93, 40);
            this.btn_View.TabIndex = 5;
            this.btn_View.Text = "View Order";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Order_Com
            // 
            this.btn_Order_Com.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Order_Com.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Order_Com.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Order_Com.Location = new System.Drawing.Point(249, 330);
            this.btn_Order_Com.Name = "btn_Order_Com";
            this.btn_Order_Com.Size = new System.Drawing.Size(93, 40);
            this.btn_Order_Com.TabIndex = 4;
            this.btn_Order_Com.Text = "Order Items";
            this.btn_Order_Com.UseVisualStyleBackColor = false;
            this.btn_Order_Com.Click += new System.EventHandler(this.btn_Order_Com_Click);
            // 
            // btn_Add_Computing
            // 
            this.btn_Add_Computing.BackColor = System.Drawing.Color.Teal;
            this.btn_Add_Computing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add_Computing.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Computing.Location = new System.Drawing.Point(427, 331);
            this.btn_Add_Computing.Name = "btn_Add_Computing";
            this.btn_Add_Computing.Size = new System.Drawing.Size(93, 40);
            this.btn_Add_Computing.TabIndex = 3;
            this.btn_Add_Computing.Text = "Add items";
            this.btn_Add_Computing.UseVisualStyleBackColor = false;
            this.btn_Add_Computing.Click += new System.EventHandler(this.btn_cAdd_Click);
            // 
            // btn_Del_Comp
            // 
            this.btn_Del_Comp.BackColor = System.Drawing.Color.Teal;
            this.btn_Del_Comp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Comp.ForeColor = System.Drawing.Color.White;
            this.btn_Del_Comp.Location = new System.Drawing.Point(527, 330);
            this.btn_Del_Comp.Name = "btn_Del_Comp";
            this.btn_Del_Comp.Size = new System.Drawing.Size(110, 41);
            this.btn_Del_Comp.TabIndex = 2;
            this.btn_Del_Comp.Text = "Remove Item";
            this.btn_Del_Comp.UseVisualStyleBackColor = false;
            this.btn_Del_Comp.Click += new System.EventHandler(this.btn_Del_Comp_Click);
            // 
            // dgv_Gaming_Emp
            // 
            this.dgv_Gaming_Emp.AllowUserToAddRows = false;
            this.dgv_Gaming_Emp.AllowUserToDeleteRows = false;
            this.dgv_Gaming_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gaming_Emp.Location = new System.Drawing.Point(117, 75);
            this.dgv_Gaming_Emp.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Gaming_Emp.Name = "dgv_Gaming_Emp";
            this.dgv_Gaming_Emp.ReadOnly = true;
            this.dgv_Gaming_Emp.RowTemplate.Height = 40;
            this.dgv_Gaming_Emp.Size = new System.Drawing.Size(520, 251);
            this.dgv_Gaming_Emp.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGreen;
            this.tabPage1.BackgroundImage = global::IMS.Properties.Resources.Log;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btn_ViewOrder);
            this.tabPage1.Controls.Add(this.btn_Order);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.btn_Del_Food);
            this.tabPage1.Controls.Add(this.dgv_Food_Emp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Food";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_ViewOrder
            // 
            this.btn_ViewOrder.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_ViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewOrder.ForeColor = System.Drawing.Color.White;
            this.btn_ViewOrder.Location = new System.Drawing.Point(137, 319);
            this.btn_ViewOrder.Name = "btn_ViewOrder";
            this.btn_ViewOrder.Size = new System.Drawing.Size(97, 41);
            this.btn_ViewOrder.TabIndex = 4;
            this.btn_ViewOrder.Text = "View Order Item";
            this.btn_ViewOrder.UseVisualStyleBackColor = false;
            this.btn_ViewOrder.Click += new System.EventHandler(this.btn_ViewOrder_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(240, 319);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(97, 41);
            this.btn_Order.TabIndex = 3;
            this.btn_Order.Text = "Order Item";
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Gray;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Location = new System.Drawing.Point(437, 319);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(97, 41);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del_Food
            // 
            this.btn_Del_Food.BackColor = System.Drawing.Color.Gray;
            this.btn_Del_Food.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Del_Food.Location = new System.Drawing.Point(540, 319);
            this.btn_Del_Food.Name = "btn_Del_Food";
            this.btn_Del_Food.Size = new System.Drawing.Size(110, 41);
            this.btn_Del_Food.TabIndex = 1;
            this.btn_Del_Food.Text = "Remove Item";
            this.btn_Del_Food.UseVisualStyleBackColor = false;
            this.btn_Del_Food.Click += new System.EventHandler(this.btn_Del_Food_Click);
            // 
            // dgv_Food_Emp
            // 
            this.dgv_Food_Emp.AllowUserToAddRows = false;
            this.dgv_Food_Emp.AllowUserToDeleteRows = false;
            this.dgv_Food_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Food_Emp.Location = new System.Drawing.Point(103, 28);
            this.dgv_Food_Emp.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Food_Emp.Name = "dgv_Food_Emp";
            this.dgv_Food_Emp.ReadOnly = true;
            this.dgv_Food_Emp.RowTemplate.Height = 40;
            this.dgv_Food_Emp.Size = new System.Drawing.Size(547, 287);
            this.dgv_Food_Emp.TabIndex = 0;
            this.dgv_Food_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Food_Emp_CellContentClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Beauty_Emp)).EndInit();
            this.Kids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kids_Emp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gaming_Emp)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Food_Emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_Food_Emp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Beauty_Emp;
        private System.Windows.Forms.TabPage Kids;
        private System.Windows.Forms.DataGridView dgv_Kids_Emp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_Gaming_Emp;
        private System.Windows.Forms.Button btn_Del_Food;
        private System.Windows.Forms.Button btn_Del_Beauty;
        private System.Windows.Forms.Button btn_Del_K;
        private System.Windows.Forms.Button btn_Del_Comp;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_badd;
        private System.Windows.Forms.Button btn_kadd;
        private System.Windows.Forms.Button btn_Add_Computing;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_ViewOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_OrderItem;
        private System.Windows.Forms.Button btn_order_Item;
        private System.Windows.Forms.Button btn_Order_Com;
        private System.Windows.Forms.Button btn_OrderView;
        private System.Windows.Forms.Button btn_ViewOrd;
        private System.Windows.Forms.Button btn_View;
    }
}