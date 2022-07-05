
namespace smk_resto1
{
    partial class Payment
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
            this.dg_payment = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_cardNumber = new System.Windows.Forms.TextBox();
            this.jml_total_py = new System.Windows.Forms.Label();
            this.bt_save_py = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order";
            // 
            // dg_payment
            // 
            this.dg_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_payment.Location = new System.Drawing.Point(28, 163);
            this.dg_payment.Name = "dg_payment";
            this.dg_payment.RowHeadersWidth = 62;
            this.dg_payment.RowTemplate.Height = 28;
            this.dg_payment.Size = new System.Drawing.Size(882, 225);
            this.dg_payment.TabIndex = 3;
            this.dg_payment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dg_payment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Payment Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bank Name";
            // 
            // tx_cardNumber
            // 
            this.tx_cardNumber.Location = new System.Drawing.Point(242, 465);
            this.tx_cardNumber.Name = "tx_cardNumber";
            this.tx_cardNumber.Size = new System.Drawing.Size(186, 26);
            this.tx_cardNumber.TabIndex = 9;
            // 
            // jml_total_py
            // 
            this.jml_total_py.AutoSize = true;
            this.jml_total_py.Location = new System.Drawing.Point(736, 408);
            this.jml_total_py.Name = "jml_total_py";
            this.jml_total_py.Size = new System.Drawing.Size(76, 20);
            this.jml_total_py.TabIndex = 11;
            this.jml_total_py.Text = "[jml_total]";
            // 
            // bt_save_py
            // 
            this.bt_save_py.Location = new System.Drawing.Point(242, 574);
            this.bt_save_py.Name = "bt_save_py";
            this.bt_save_py.Size = new System.Drawing.Size(98, 38);
            this.bt_save_py.TabIndex = 12;
            this.bt_save_py.Text = "Save";
            this.bt_save_py.UseVisualStyleBackColor = true;
            this.bt_save_py.Click += new System.EventHandler(this.bt_save_py_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(396, 103);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(242, 420);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(242, 506);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 28);
            this.comboBox3.TabIndex = 15;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(940, 648);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_save_py);
            this.Controls.Add(this.jml_total_py);
            this.Controls.Add(this.tx_cardNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_payment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_cardNumber;
        private System.Windows.Forms.Label jml_total_py;
        private System.Windows.Forms.Button bt_save_py;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}