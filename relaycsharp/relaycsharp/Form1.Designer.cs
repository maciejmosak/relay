namespace relaycsharp
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
            this.ComList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Baudrate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.button3.Location = new System.Drawing.Point(296, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 138);
            this.button3.TabIndex = 3;
            this.button3.Text = "Relay 1";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(485, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 138);
            this.button4.TabIndex = 4;
            this.button4.Text = "Relay 2";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 138);
            this.button5.TabIndex = 5;
            this.button5.Text = "Relay 3";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 138);
            this.button6.TabIndex = 6;
            this.button6.Text = "Relay 4";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 569);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

