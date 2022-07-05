
namespace smk_resto1
{
    partial class Manage_member
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
            this.dg_member = new System.Windows.Forms.DataGridView();
            this.tx_src_member = new System.Windows.Forms.TextBox();
            this.src_member = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_handphone = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_name_member = new System.Windows.Forms.TextBox();
            this.memberid = new System.Windows.Forms.TextBox();
            this.btn_ins_member = new System.Windows.Forms.Button();
            this.btn_upt_member = new System.Windows.Forms.Button();
            this.btn_del_member = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_member)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Member";
            // 
            // dg_member
            // 
            this.dg_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_member.Location = new System.Drawing.Point(12, 78);
            this.dg_member.Name = "dg_member";
            this.dg_member.RowHeadersWidth = 62;
            this.dg_member.RowTemplate.Height = 28;
            this.dg_member.Size = new System.Drawing.Size(898, 246);
            this.dg_member.TabIndex = 1;
            this.dg_member.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_member_CellClick);
            this.dg_member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_member_CellContentClick);
            // 
            // tx_src_member
            // 
            this.tx_src_member.Location = new System.Drawing.Point(12, 335);
            this.tx_src_member.Name = "tx_src_member";
            this.tx_src_member.Size = new System.Drawing.Size(139, 26);
            this.tx_src_member.TabIndex = 2;
            // 
            // src_member
            // 
            this.src_member.Location = new System.Drawing.Point(171, 331);
            this.src_member.Name = "src_member";
            this.src_member.Size = new System.Drawing.Size(84, 35);
            this.src_member.TabIndex = 3;
            this.src_member.Text = "Search";
            this.src_member.UseVisualStyleBackColor = true;
            this.src_member.Click += new System.EventHandler(this.src_member_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MemberId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "HandPhone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // tx_handphone
            // 
            this.tx_handphone.Location = new System.Drawing.Point(630, 467);
            this.tx_handphone.Name = "tx_handphone";
            this.tx_handphone.Size = new System.Drawing.Size(259, 26);
            this.tx_handphone.TabIndex = 8;
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(630, 424);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(259, 26);
            this.tx_email.TabIndex = 9;
            // 
            // tx_name_member
            // 
            this.tx_name_member.Location = new System.Drawing.Point(630, 387);
            this.tx_name_member.Name = "tx_name_member";
            this.tx_name_member.Size = new System.Drawing.Size(259, 26);
            this.tx_name_member.TabIndex = 10;
            // 
            // memberid
            // 
            this.memberid.Location = new System.Drawing.Point(630, 346);
            this.memberid.Name = "memberid";
            this.memberid.Size = new System.Drawing.Size(259, 26);
            this.memberid.TabIndex = 11;
            // 
            // btn_ins_member
            // 
            this.btn_ins_member.Location = new System.Drawing.Point(297, 546);
            this.btn_ins_member.Name = "btn_ins_member";
            this.btn_ins_member.Size = new System.Drawing.Size(84, 35);
            this.btn_ins_member.TabIndex = 12;
            this.btn_ins_member.Text = "Insert";
            this.btn_ins_member.UseVisualStyleBackColor = true;
            this.btn_ins_member.Click += new System.EventHandler(this.btn_ins_member_Click);
            // 
            // btn_upt_member
            // 
            this.btn_upt_member.Location = new System.Drawing.Point(410, 546);
            this.btn_upt_member.Name = "btn_upt_member";
            this.btn_upt_member.Size = new System.Drawing.Size(84, 35);
            this.btn_upt_member.TabIndex = 13;
            this.btn_upt_member.Text = "Update";
            this.btn_upt_member.UseVisualStyleBackColor = true;
            this.btn_upt_member.Click += new System.EventHandler(this.btn_upt_member_Click);
            // 
            // btn_del_member
            // 
            this.btn_del_member.Location = new System.Drawing.Point(524, 546);
            this.btn_del_member.Name = "btn_del_member";
            this.btn_del_member.Size = new System.Drawing.Size(84, 35);
            this.btn_del_member.TabIndex = 14;
            this.btn_del_member.Text = "Delete";
            this.btn_del_member.UseVisualStyleBackColor = true;
            this.btn_del_member.Click += new System.EventHandler(this.btn_del_member_Click);
            // 
            // Manage_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 593);
            this.Controls.Add(this.btn_del_member);
            this.Controls.Add(this.btn_upt_member);
            this.Controls.Add(this.btn_ins_member);
            this.Controls.Add(this.memberid);
            this.Controls.Add(this.tx_name_member);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_handphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.src_member);
            this.Controls.Add(this.tx_src_member);
            this.Controls.Add(this.dg_member);
            this.Controls.Add(this.label1);
            this.Name = "Manage_member";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Manage_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_member;
        private System.Windows.Forms.TextBox tx_src_member;
        private System.Windows.Forms.Button src_member;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_handphone;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_name_member;
        private System.Windows.Forms.TextBox memberid;
        private System.Windows.Forms.Button btn_ins_member;
        private System.Windows.Forms.Button btn_upt_member;
        private System.Windows.Forms.Button btn_del_member;
    }
}