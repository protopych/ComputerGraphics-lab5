﻿namespace ComputerGraphic_lab5
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_box_HR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.text_box_HL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(132, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 394);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // text_box_HR
            // 
            this.text_box_HR.Location = new System.Drawing.Point(32, 180);
            this.text_box_HR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_box_HR.Name = "text_box_HR";
            this.text_box_HR.Size = new System.Drawing.Size(55, 20);
            this.text_box_HR.TabIndex = 2;
            this.text_box_HR.Text = "10";
            this.text_box_HR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "R";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(32, 227);
            this.textBox_R.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(55, 20);
            this.textBox_R.TabIndex = 6;
            this.textBox_R.Text = "1";
            this.textBox_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_R.TextChanged += new System.EventHandler(this.textBox_R_TextChanged);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_start.Location = new System.Drawing.Point(23, 24);
            this.button_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(77, 31);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "Построить";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(23, 73);
            this.clear_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(77, 24);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Очистить ";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // text_box_HL
            // 
            this.text_box_HL.Location = new System.Drawing.Point(32, 129);
            this.text_box_HL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_box_HL.Name = "text_box_HL";
            this.text_box_HL.Size = new System.Drawing.Size(55, 20);
            this.text_box_HL.TabIndex = 10;
            this.text_box_HL.Text = "10";
            this.text_box_HL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 438);
            this.Controls.Add(this.text_box_HL);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_box_HR);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "2. Алгоритм midpoint displacement";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_box_HR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox text_box_HL;
    }
}