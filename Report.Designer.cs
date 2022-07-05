
namespace smk_resto1
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_form = new System.Windows.Forms.TextBox();
            this.bt_generate = new System.Windows.Forms.Button();
            this.tx_to = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ch_report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_report)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form";
            // 
            // tx_form
            // 
            this.tx_form.Location = new System.Drawing.Point(347, 95);
            this.tx_form.Name = "tx_form";
            this.tx_form.Size = new System.Drawing.Size(221, 26);
            this.tx_form.TabIndex = 2;
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(605, 146);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(102, 35);
            this.bt_generate.TabIndex = 3;
            this.bt_generate.Text = "Generate";
            this.bt_generate.UseVisualStyleBackColor = true;
            // 
            // tx_to
            // 
            this.tx_to.Location = new System.Drawing.Point(347, 150);
            this.tx_to.Name = "tx_to";
            this.tx_to.Size = new System.Drawing.Size(221, 26);
            this.tx_to.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(885, 177);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ch_report
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_report.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_report.Legends.Add(legend1);
            this.ch_report.Location = new System.Drawing.Point(24, 402);
            this.ch_report.Name = "ch_report";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_report.Series.Add(series1);
            this.ch_report.Size = new System.Drawing.Size(885, 300);
            this.ch_report.TabIndex = 7;
            this.ch_report.Text = "chart1";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(934, 779);
            this.Controls.Add(this.ch_report);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.tx_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_form;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.TextBox tx_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_report;
    }
}