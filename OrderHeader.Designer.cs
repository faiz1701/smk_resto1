
namespace smk_resto1
{
    partial class OrderHeader
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
            this.dg_orderAtas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_MenuName = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.tx_qtyOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_order = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.jml_carbo = new System.Windows.Forms.Label();
            this.jml_protein = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pic_order = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orderAtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_order)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Order";
            // 
            // dg_orderAtas
            // 
            this.dg_orderAtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orderAtas.Location = new System.Drawing.Point(12, 80);
            this.dg_orderAtas.Name = "dg_orderAtas";
            this.dg_orderAtas.RowHeadersWidth = 62;
            this.dg_orderAtas.RowTemplate.Height = 28;
            this.dg_orderAtas.Size = new System.Drawing.Size(917, 213);
            this.dg_orderAtas.TabIndex = 3;
            this.dg_orderAtas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_orderAtas_CellClick);
            this.dg_orderAtas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu Name";
            // 
            // tx_MenuName
            // 
            this.tx_MenuName.Location = new System.Drawing.Point(642, 318);
            this.tx_MenuName.Name = "tx_MenuName";
            this.tx_MenuName.Size = new System.Drawing.Size(173, 26);
            this.tx_MenuName.TabIndex = 5;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(523, 447);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(87, 32);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tx_qtyOrder
            // 
            this.tx_qtyOrder.Location = new System.Drawing.Point(642, 367);
            this.tx_qtyOrder.Name = "tx_qtyOrder";
            this.tx_qtyOrder.Size = new System.Drawing.Size(173, 26);
            this.tx_qtyOrder.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qty";
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(661, 447);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(87, 32);
            this.bt_del.TabIndex = 9;
            this.bt_del.Text = "Delete";
            this.bt_del.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(917, 213);
            this.dataGridView1.TabIndex = 10;
            // 
            // bt_order
            // 
            this.bt_order.Location = new System.Drawing.Point(438, 714);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(87, 32);
            this.bt_order.TabIndex = 11;
            this.bt_order.Text = "Order";
            this.bt_order.UseVisualStyleBackColor = true;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Carbo :";
            // 
            // jml_carbo
            // 
            this.jml_carbo.AutoSize = true;
            this.jml_carbo.Location = new System.Drawing.Point(89, 720);
            this.jml_carbo.Name = "jml_carbo";
            this.jml_carbo.Size = new System.Drawing.Size(17, 20);
            this.jml_carbo.TabIndex = 13;
            this.jml_carbo.Text = "[]";
            // 
            // jml_protein
            // 
            this.jml_protein.AutoSize = true;
            this.jml_protein.Location = new System.Drawing.Point(201, 720);
            this.jml_protein.Name = "jml_protein";
            this.jml_protein.Size = new System.Drawing.Size(17, 20);
            this.jml_protein.TabIndex = 15;
            this.jml_protein.Text = "[]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Protein :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(745, 720);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(17, 20);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "[]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 720);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total :";
            // 
            // pic_order
            // 
            this.pic_order.Location = new System.Drawing.Point(302, 318);
            this.pic_order.Name = "pic_order";
            this.pic_order.Size = new System.Drawing.Size(159, 127);
            this.pic_order.TabIndex = 18;
            this.pic_order.TabStop = false;
            // 
            // OrderHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(941, 781);
            this.Controls.Add(this.pic_order);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.jml_protein);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jml_carbo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_order);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.tx_qtyOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tx_MenuName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_orderAtas);
            this.Controls.Add(this.label1);
            this.Name = "OrderHeader";
            this.Text = "OrderHeader";
            this.Load += new System.EventHandler(this.OrderHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_orderAtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_orderAtas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_MenuName;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tx_qtyOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label jml_carbo;
        private System.Windows.Forms.Label jml_protein;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_order;
    }
}