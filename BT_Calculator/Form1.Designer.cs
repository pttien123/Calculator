﻿namespace BT_Calculator
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.button2 = new System.Windows.Forms.Button();
=======
            this.bttru = new System.Windows.Forms.Button();
>>>>>>> nhanh1
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(32, 186);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(122, 51);
            this.btcong.TabIndex = 2;
            this.btcong.Text = "Cộng";
            this.btcong.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 0;
            // 
<<<<<<< HEAD
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
=======
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(175, 186);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(122, 51);
            this.bttru.TabIndex = 2;
            this.bttru.Text = "Trừ";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bttru_Click);
>>>>>>> nhanh1
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 265);
<<<<<<< HEAD
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
=======
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
>>>>>>> nhanh1
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bttru;
    }
}

