namespace KMLab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDa = new System.Windows.Forms.NumericUpDown();
            this.numUDb = new System.Windows.Forms.NumericUpDown();
            this.lblRes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblSrRes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTochn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 206);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "b=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "a=";
            // 
            // numUDa
            // 
            this.numUDa.Location = new System.Drawing.Point(60, 129);
            this.numUDa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUDa.Name = "numUDa";
            this.numUDa.Size = new System.Drawing.Size(67, 20);
            this.numUDa.TabIndex = 3;
            this.numUDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDb
            // 
            this.numUDb.Location = new System.Drawing.Point(52, 3);
            this.numUDb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDb.Name = "numUDb";
            this.numUDb.Size = new System.Drawing.Size(67, 20);
            this.numUDb.TabIndex = 4;
            this.numUDb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(206, 80);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(149, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 93);
            this.dataGridView1.TabIndex = 8;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(329, 27);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(149, 20);
            this.tbN.TabIndex = 9;
            this.tbN.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "n=";
            // 
            // lblOz
            // 
            this.lblOz.AutoSize = true;
            this.lblOz.Location = new System.Drawing.Point(219, 136);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(0, 13);
            this.lblOz.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1+x";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(60, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "e^e^x";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(60, 93);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "sin(x)/x";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblSrRes
            // 
            this.lblSrRes.AutoSize = true;
            this.lblSrRes.Location = new System.Drawing.Point(438, 177);
            this.lblSrRes.Name = "lblSrRes";
            this.lblSrRes.Size = new System.Drawing.Size(0, 13);
            this.lblSrRes.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Точное значение для проверки";
            // 
            // tbTochn
            // 
            this.tbTochn.Location = new System.Drawing.Point(183, 190);
            this.tbTochn.Name = "tbTochn";
            this.tbTochn.Size = new System.Drawing.Size(100, 20);
            this.tbTochn.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 73);
            this.label5.TabIndex = 18;
            this.label5.Text = "∫";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "dx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTochn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSrRes);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.numUDb);
            this.Controls.Add(this.numUDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Вычисление определного интеграла методом Монте-Карло";
            ((System.ComponentModel.ISupportInitialize)(this.numUDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDa;
        private System.Windows.Forms.NumericUpDown numUDb;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblSrRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTochn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

