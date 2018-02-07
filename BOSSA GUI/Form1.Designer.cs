namespace BOSSA_GUI
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
            this.openfile = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1444, 310);
            this.textBox1.TabIndex = 1;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(35, 39);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(271, 61);
            this.openfile.TabIndex = 2;
            this.openfile.Text = "Open Firmware File";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.find_file_click);
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(352, 71);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(1127, 29);
            this.fileBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "firmware file:";
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(352, 139);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(268, 32);
            this.comPortBox.TabIndex = 6;
            this.comPortBox.Text = "Refresh Serial Ports";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1208, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Flash New Firmware";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_1_click);
            // 
            // refreshSerial
            // 
            this.refreshSerial.Location = new System.Drawing.Point(35, 124);
            this.refreshSerial.Name = "refreshSerial";
            this.refreshSerial.Size = new System.Drawing.Size(271, 61);
            this.refreshSerial.TabIndex = 7;
            this.refreshSerial.Text = "Refresh Serial Ports";
            this.refreshSerial.UseVisualStyleBackColor = true;
            this.refreshSerial.Click += new System.EventHandler(this.refreshSerialPorts);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 544);
            this.Controls.Add(this.refreshSerial);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1547, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1547, 608);
            this.Name = "Form1";
            this.Text = "DePinga Flashing Tool v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshSerial;
    }
}

