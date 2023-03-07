namespace MultithreadingProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_thread1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_thread2 = new System.Windows.Forms.Button();
            this.btn_thread3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btn_thread1
            // 
            this.btn_thread1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thread1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thread1.ForeColor = System.Drawing.Color.Red;
            this.btn_thread1.Location = new System.Drawing.Point(12, 12);
            this.btn_thread1.Name = "btn_thread1";
            this.btn_thread1.Size = new System.Drawing.Size(104, 44);
            this.btn_thread1.TabIndex = 0;
            this.btn_thread1.Text = "Thread 1";
            this.btn_thread1.UseVisualStyleBackColor = true;
            this.btn_thread1.Click += new System.EventHandler(this.btn_thread1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Location = new System.Drawing.Point(600, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(272, 447);
            this.textBox1.TabIndex = 3;
            // 
            // btn_thread2
            // 
            this.btn_thread2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thread2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thread2.ForeColor = System.Drawing.Color.Blue;
            this.btn_thread2.Location = new System.Drawing.Point(300, 12);
            this.btn_thread2.Name = "btn_thread2";
            this.btn_thread2.Size = new System.Drawing.Size(104, 44);
            this.btn_thread2.TabIndex = 4;
            this.btn_thread2.Text = "Thread 2";
            this.btn_thread2.UseVisualStyleBackColor = true;
            this.btn_thread2.Click += new System.EventHandler(this.btn_thread2_Click);
            // 
            // btn_thread3
            // 
            this.btn_thread3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thread3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thread3.Location = new System.Drawing.Point(600, 12);
            this.btn_thread3.Name = "btn_thread3";
            this.btn_thread3.Size = new System.Drawing.Size(104, 44);
            this.btn_thread3.TabIndex = 5;
            this.btn_thread3.Text = "Thread 3";
            this.btn_thread3.UseVisualStyleBackColor = true;
            this.btn_thread3.Click += new System.EventHandler(this.btn_thread3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(600, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 34);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_thread3);
            this.Controls.Add(this.btn_thread2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_thread1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multithreading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_thread1;
        private TextBox textBox1;
        private Button btn_thread2;
        private Button btn_thread3;
        private ProgressBar progressBar1;
    }
}