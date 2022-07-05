
namespace smk_resto1
{
    partial class Admin_nav
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
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.admin_name = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Navigation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(263, 172);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(222, 40);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(263, 218);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(222, 40);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Manage Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_member
            // 
            this.btn_member.Location = new System.Drawing.Point(263, 264);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(222, 40);
            this.btn_member.TabIndex = 4;
            this.btn_member.Text = "Manage Member";
            this.btn_member.UseVisualStyleBackColor = true;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(263, 310);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(222, 40);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // admin_name
            // 
            this.admin_name.AutoSize = true;
            this.admin_name.Location = new System.Drawing.Point(126, 121);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(0, 20);
            this.admin_name.TabIndex = 6;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(133, 121);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 20);
            this.labelUser.TabIndex = 7;
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // Admin_nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.admin_name);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_member);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin_nav";
            this.Text = "Admin_nav";
            this.Load += new System.EventHandler(this.Admin_nav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label admin_name;
        private System.Windows.Forms.Label labelUser;
    }
}