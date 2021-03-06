﻿namespace relaycsharp
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
            this.ComList = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComList
            // 
            this.ComList.AccessibleName = "Com list";
            this.ComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComList.FormattingEnabled = true;
            this.ComList.Location = new System.Drawing.Point(235, 103);
            this.ComList.Name = "ComList";
            this.ComList.Size = new System.Drawing.Size(157, 33);
            this.ComList.TabIndex = 0;
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200 \t",
            "128000",
            "153600 \t",
            "230400",
            "256000 \t",
            "460800",
            "921600"});
            this.baudrate.Location = new System.Drawing.Point(430, 103);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(229, 33);
            this.baudrate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Baudrate";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 138);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh ports list";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 138);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(296, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 138);
            this.button3.TabIndex = 3;
            this.button3.Text = "Relay 1";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(485, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 138);
            this.button4.TabIndex = 4;
            this.button4.Text = "Relay 2";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(296, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 138);
            this.button5.TabIndex = 5;
            this.button5.Text = "Relay 3";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(485, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 138);
            this.button6.TabIndex = 6;
            this.button6.Text = "Relay 4";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(728, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(183, 138);
            this.button7.TabIndex = 7;
            this.button7.Text = "Relay 5";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(917, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(183, 138);
            this.button8.TabIndex = 8;
            this.button8.Text = "Relay 6";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(728, 359);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(183, 138);
            this.button9.TabIndex = 9;
            this.button9.Text = "Relay 7";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(917, 359);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(183, 138);
            this.button10.TabIndex = 10;
            this.button10.Text = "Relay 8";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.AnyButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Device name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "no device connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baudrate);
            this.Controls.Add(this.ComList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RelayControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

