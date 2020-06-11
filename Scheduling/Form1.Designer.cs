namespace Scheduling
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TurnaroundTimeLabel = new System.Windows.Forms.Label();
            this.WaitTimeLabel = new System.Windows.Forms.Label();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TurnaroundTimeTextBox = new System.Windows.Forms.TextBox();
            this.WaitTimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "先到先做排程(First-Come First-Serve, FCFS)",
            "最短剩餘時間優先(Shortest Remaining Time, SRT)",
            "優先權排程(Priority Scheduling, PS)",
            "循環分時排程(Round-Robin Scheduling, RR)"});
            this.comboBox1.Location = new System.Drawing.Point(14, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(764, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "請選擇排程";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Consolas", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(14, 96);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(764, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "總共要多少行程(最多5個)";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(496, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "開始執行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TurnaroundTimeLabel
            // 
            this.TurnaroundTimeLabel.AutoSize = true;
            this.TurnaroundTimeLabel.Font = new System.Drawing.Font("Consolas", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnaroundTimeLabel.Location = new System.Drawing.Point(493, 196);
            this.TurnaroundTimeLabel.Name = "TurnaroundTimeLabel";
            this.TurnaroundTimeLabel.Size = new System.Drawing.Size(238, 17);
            this.TurnaroundTimeLabel.TabIndex = 5;
            this.TurnaroundTimeLabel.Text = "平均回覆時間(Turnround Time)";
            this.TurnaroundTimeLabel.Visible = false;
            // 
            // WaitTimeLabel
            // 
            this.WaitTimeLabel.AutoSize = true;
            this.WaitTimeLabel.Font = new System.Drawing.Font("Consolas", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitTimeLabel.Location = new System.Drawing.Point(493, 280);
            this.WaitTimeLabel.Name = "WaitTimeLabel";
            this.WaitTimeLabel.Size = new System.Drawing.Size(198, 17);
            this.WaitTimeLabel.TabIndex = 6;
            this.WaitTimeLabel.Text = "平均等待時間(Wait Time)";
            this.WaitTimeLabel.Visible = false;
            // 
            // DrawBox
            // 
            this.DrawBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawBox.Location = new System.Drawing.Point(12, 370);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(770, 70);
            this.DrawBox.TabIndex = 7;
            this.DrawBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(496, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "亂數產生值";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TurnaroundTimeTextBox
            // 
            this.TurnaroundTimeTextBox.BackColor = System.Drawing.Color.White;
            this.TurnaroundTimeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnaroundTimeTextBox.Location = new System.Drawing.Point(496, 216);
            this.TurnaroundTimeTextBox.Multiline = true;
            this.TurnaroundTimeTextBox.Name = "TurnaroundTimeTextBox";
            this.TurnaroundTimeTextBox.ReadOnly = true;
            this.TurnaroundTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnaroundTimeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TurnaroundTimeTextBox.Size = new System.Drawing.Size(282, 61);
            this.TurnaroundTimeTextBox.TabIndex = 9;
            this.TurnaroundTimeTextBox.Visible = false;
            // 
            // WaitTimeTextBox
            // 
            this.WaitTimeTextBox.BackColor = System.Drawing.Color.White;
            this.WaitTimeTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitTimeTextBox.Location = new System.Drawing.Point(496, 300);
            this.WaitTimeTextBox.Multiline = true;
            this.WaitTimeTextBox.Name = "WaitTimeTextBox";
            this.WaitTimeTextBox.ReadOnly = true;
            this.WaitTimeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WaitTimeTextBox.Size = new System.Drawing.Size(282, 61);
            this.WaitTimeTextBox.TabIndex = 10;
            this.WaitTimeTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(806, 455);
            this.Controls.Add(this.WaitTimeTextBox);
            this.Controls.Add(this.TurnaroundTimeTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DrawBox);
            this.Controls.Add(this.WaitTimeLabel);
            this.Controls.Add(this.TurnaroundTimeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "作業系統作業";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TurnaroundTimeLabel;
        private System.Windows.Forms.Label WaitTimeLabel;
        private System.Windows.Forms.PictureBox DrawBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TurnaroundTimeTextBox;
        private System.Windows.Forms.TextBox WaitTimeTextBox;
    }
}

