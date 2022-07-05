
namespace smk_resto1
{
    partial class Manage_menu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.src_menu = new System.Windows.Forms.Button();
            this.dg_menu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_menuId = new System.Windows.Forms.TextBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_protein_menu = new System.Windows.Forms.TextBox();
            this.tx_carbon_menu = new System.Windows.Forms.TextBox();
            this.tx_photo_menu = new System.Windows.Forms.TextBox();
            this.tx_price_menu = new System.Windows.Forms.TextBox();
            this.tx_name_menu = new System.Windows.Forms.TextBox();
            this.btn_create_menu = new System.Windows.Forms.Button();
            this.btn_edit_menu = new System.Windows.Forms.Button();
            this.btn_delete_menu = new System.Windows.Forms.Button();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Menu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 1;
            // 
            // src_menu
            // 
            this.src_menu.Location = new System.Drawing.Point(822, 89);
            this.src_menu.Name = "src_menu";
            this.src_menu.Size = new System.Drawing.Size(98, 38);
            this.src_menu.TabIndex = 2;
            this.src_menu.Text = "Search";
            this.src_menu.UseVisualStyleBackColor = true;
            this.src_menu.Click += new System.EventHandler(this.src_menu_Click);
            // 
            // dg_menu
            // 
            this.dg_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_menu.Location = new System.Drawing.Point(22, 142);
            this.dg_menu.Name = "dg_menu";
            this.dg_menu.RowHeadersWidth = 62;
            this.dg_menu.RowTemplate.Height = 28;
            this.dg_menu.Size = new System.Drawing.Size(897, 289);
            this.dg_menu.TabIndex = 3;
            this.dg_menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_menu_CellClick);
            this.dg_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_menu_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "MenuId";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tx_menuId
            // 
            this.tx_menuId.Location = new System.Drawing.Point(146, 462);
            this.tx_menuId.Name = "tx_menuId";
            this.tx_menuId.Size = new System.Drawing.Size(204, 26);
            this.tx_menuId.TabIndex = 6;
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(370, 608);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(70, 32);
            this.btn_image.TabIndex = 7;
            this.btn_image.Text = "...";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Protein";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Carbon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // tx_protein_menu
            // 
            this.tx_protein_menu.Location = new System.Drawing.Point(146, 695);
            this.tx_protein_menu.Name = "tx_protein_menu";
            this.tx_protein_menu.Size = new System.Drawing.Size(204, 26);
            this.tx_protein_menu.TabIndex = 13;
            // 
            // tx_carbon_menu
            // 
            this.tx_carbon_menu.Location = new System.Drawing.Point(146, 652);
            this.tx_carbon_menu.Name = "tx_carbon_menu";
            this.tx_carbon_menu.Size = new System.Drawing.Size(204, 26);
            this.tx_carbon_menu.TabIndex = 14;
            // 
            // tx_photo_menu
            // 
            this.tx_photo_menu.Location = new System.Drawing.Point(146, 608);
            this.tx_photo_menu.Name = "tx_photo_menu";
            this.tx_photo_menu.Size = new System.Drawing.Size(204, 26);
            this.tx_photo_menu.TabIndex = 15;
            // 
            // tx_price_menu
            // 
            this.tx_price_menu.Location = new System.Drawing.Point(146, 562);
            this.tx_price_menu.Name = "tx_price_menu";
            this.tx_price_menu.Size = new System.Drawing.Size(204, 26);
            this.tx_price_menu.TabIndex = 16;
            // 
            // tx_name_menu
            // 
            this.tx_name_menu.Location = new System.Drawing.Point(146, 508);
            this.tx_name_menu.Name = "tx_name_menu";
            this.tx_name_menu.Size = new System.Drawing.Size(204, 26);
            this.tx_name_menu.TabIndex = 17;
            // 
            // btn_create_menu
            // 
            this.btn_create_menu.Location = new System.Drawing.Point(484, 686);
            this.btn_create_menu.Name = "btn_create_menu";
            this.btn_create_menu.Size = new System.Drawing.Size(99, 35);
            this.btn_create_menu.TabIndex = 20;
            this.btn_create_menu.Text = "Insert";
            this.btn_create_menu.UseVisualStyleBackColor = true;
            this.btn_create_menu.Click += new System.EventHandler(this.btn_create_menu_Click);
            // 
            // btn_edit_menu
            // 
            this.btn_edit_menu.Location = new System.Drawing.Point(646, 686);
            this.btn_edit_menu.Name = "btn_edit_menu";
            this.btn_edit_menu.Size = new System.Drawing.Size(99, 35);
            this.btn_edit_menu.TabIndex = 21;
            this.btn_edit_menu.Text = "Update";
            this.btn_edit_menu.UseVisualStyleBackColor = true;
            this.btn_edit_menu.Click += new System.EventHandler(this.btn_edit_menu_Click);
            // 
            // btn_delete_menu
            // 
            this.btn_delete_menu.Location = new System.Drawing.Point(800, 688);
            this.btn_delete_menu.Name = "btn_delete_menu";
            this.btn_delete_menu.Size = new System.Drawing.Size(99, 35);
            this.btn_delete_menu.TabIndex = 22;
            this.btn_delete_menu.Text = "Delete";
            this.btn_delete_menu.UseVisualStyleBackColor = true;
            this.btn_delete_menu.Click += new System.EventHandler(this.btn_delete_menu_Click);
            // 
            // pic_menu
            // 
            this.pic_menu.Location = new System.Drawing.Point(560, 462);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(227, 172);
            this.pic_menu.TabIndex = 23;
            this.pic_menu.TabStop = false;
            // 
            // Manage_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(940, 702);
            this.Controls.Add(this.pic_menu);
            this.Controls.Add(this.btn_delete_menu);
            this.Controls.Add(this.btn_edit_menu);
            this.Controls.Add(this.btn_create_menu);
            this.Controls.Add(this.tx_name_menu);
            this.Controls.Add(this.tx_price_menu);
            this.Controls.Add(this.tx_photo_menu);
            this.Controls.Add(this.tx_carbon_menu);
            this.Controls.Add(this.tx_protein_menu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.tx_menuId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_menu);
            this.Controls.Add(this.src_menu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Manage_menu";
            this.Text = "Manage_menu";
            this.Load += new System.EventHandler(this.Manage_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button src_menu;
        private System.Windows.Forms.DataGridView dg_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_menuId;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_protein_menu;
        private System.Windows.Forms.TextBox tx_carbon_menu;
        private System.Windows.Forms.TextBox tx_photo_menu;
        private System.Windows.Forms.TextBox tx_price_menu;
        private System.Windows.Forms.TextBox tx_name_menu;
        private System.Windows.Forms.Button btn_create_menu;
        private System.Windows.Forms.Button btn_edit_menu;
        private System.Windows.Forms.Button btn_delete_menu;
        private System.Windows.Forms.PictureBox pic_menu;
    }
}