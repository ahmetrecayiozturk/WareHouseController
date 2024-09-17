namespace WareHouseController3
{
    partial class ShowDailyProfit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalProfitLabel = new System.Windows.Forms.Label();
            this.productProfitListBox = new System.Windows.Forms.ListBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.veresiyekar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // totalProfitLabel
            // 
            this.totalProfitLabel.AutoSize = true;
            this.totalProfitLabel.Location = new System.Drawing.Point(869, 367);
            this.totalProfitLabel.Name = "totalProfitLabel";
            this.totalProfitLabel.Size = new System.Drawing.Size(160, 16);
            this.totalProfitLabel.TabIndex = 1;
            this.totalProfitLabel.Text = "Karlar Burada Gözükecek";
            this.totalProfitLabel.Click += new System.EventHandler(this.totalProfitLabel_Click);
            // 
            // productProfitListBox
            // 
            this.productProfitListBox.FormattingEnabled = true;
            this.productProfitListBox.ItemHeight = 16;
            this.productProfitListBox.Location = new System.Drawing.Point(12, 367);
            this.productProfitListBox.Name = "productProfitListBox";
            this.productProfitListBox.Size = new System.Drawing.Size(641, 244);
            this.productProfitListBox.TabIndex = 2;
            this.productProfitListBox.SelectedIndexChanged += new System.EventHandler(this.productProfitListBox_SelectedIndexChanged);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(15, 18);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 3;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 237);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(354, 106);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "GÜNLÜK KARI GÖSTER";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOPLAM GÜNLÜK KAR       =";
            // 
            // veresiyekar
            // 
            this.veresiyekar.Location = new System.Drawing.Point(704, 513);
            this.veresiyekar.Name = "veresiyekar";
            this.veresiyekar.Size = new System.Drawing.Size(500, 98);
            this.veresiyekar.TabIndex = 6;
            this.veresiyekar.Text = "VERESİYE KARINI GÖSTER";
            this.veresiyekar.UseVisualStyleBackColor = true;
            this.veresiyekar.Click += new System.EventHandler(this.veresiyekar_Click);
            // 
            // ShowDailyProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 623);
            this.Controls.Add(this.veresiyekar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.productProfitListBox);
            this.Controls.Add(this.totalProfitLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowDailyProfit";
            this.Text = "ShowDailyProfit";
            this.Load += new System.EventHandler(this.ShowDailyProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalProfitLabel;
        private System.Windows.Forms.ListBox productProfitListBox;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button veresiyekar;
    }
}