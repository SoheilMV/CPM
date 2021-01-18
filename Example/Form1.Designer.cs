namespace Example
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
            this.components = new System.ComponentModel.Container();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblCpm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(168, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblCpm
            // 
            this.lblCpm.AutoSize = true;
            this.lblCpm.Location = new System.Drawing.Point(12, 47);
            this.lblCpm.Name = "lblCpm";
            this.lblCpm.Size = new System.Drawing.Size(45, 13);
            this.lblCpm.TabIndex = 1;
            this.lblCpm.Text = "CPM : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(12, 65);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(65, 13);
            this.lblCheck.TabIndex = 1;
            this.lblCheck.Text = "Checked : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 94);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblCpm);
            this.Controls.Add(this.btnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checks Per Minute";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblCpm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCheck;
    }
}

