
namespace smk_resto1
{
    partial class Cashier_nav
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
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.labelCashier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Navigation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(289, 201);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(201, 45);
            this.btn_payment.TabIndex = 2;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(289, 270);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(201, 45);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // labelCashier
            // 
            this.labelCashier.AutoSize = true;
            this.labelCashier.Location = new System.Drawing.Point(155, 146);
            this.labelCashier.Name = "labelCashier";
            this.labelCashier.Size = new System.Drawing.Size(0, 20);
            this.labelCashier.TabIndex = 4;
            // 
            // Cashier_nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCashier);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cashier_nav";
            this.Text = "Cashier_nav";
            this.Load += new System.EventHandler(this.Cashier_nav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label labelCashier;
    }
}