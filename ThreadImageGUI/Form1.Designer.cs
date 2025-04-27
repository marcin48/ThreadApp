namespace ImageThreadGui
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
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            button_Load = new Button();
            button_Process = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            button_Single = new Button();
            button_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 540);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_Load
            // 
            button_Load.BackColor = SystemColors.GradientInactiveCaption;
            button_Load.Font = new Font("Segoe UI", 12F);
            button_Load.ForeColor = SystemColors.ActiveCaptionText;
            button_Load.Location = new Point(433, 47);
            button_Load.Name = "button_Load";
            button_Load.Size = new Size(150, 100);
            button_Load.TabIndex = 1;
            button_Load.Text = "Load";
            button_Load.UseVisualStyleBackColor = false;
            button_Load.Click += button_Load_Click;
            // 
            // button_Process
            // 
            button_Process.BackColor = SystemColors.GradientInactiveCaption;
            button_Process.Font = new Font("Segoe UI", 12F);
            button_Process.ForeColor = SystemColors.ActiveCaptionText;
            button_Process.Location = new Point(433, 197);
            button_Process.Name = "button_Process";
            button_Process.Size = new Size(150, 100);
            button_Process.TabIndex = 2;
            button_Process.Text = "Parallel\r\nProcess";
            button_Process.UseVisualStyleBackColor = false;
            button_Process.Click += button_Process_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(623, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(623, 337);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 250);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1036, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(1036, 337);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(250, 250);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // button_Single
            // 
            button_Single.BackColor = SystemColors.GradientInactiveCaption;
            button_Single.Font = new Font("Segoe UI", 12F);
            button_Single.ForeColor = SystemColors.ActiveCaptionText;
            button_Single.Location = new Point(433, 337);
            button_Single.Name = "button_Single";
            button_Single.Size = new Size(150, 100);
            button_Single.TabIndex = 7;
            button_Single.Text = "Single\r\nProcess";
            button_Single.UseVisualStyleBackColor = false;
            button_Single.Click += button_Single_Click;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = SystemColors.GradientInactiveCaption;
            button_Clear.Font = new Font("Segoe UI", 12F);
            button_Clear.ForeColor = SystemColors.ActiveCaptionText;
            button_Clear.Location = new Point(433, 487);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(150, 100);
            button_Clear.TabIndex = 8;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 643);
            Controls.Add(button_Clear);
            Controls.Add(button_Single);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(button_Process);
            Controls.Add(button_Load);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button button_Load;
        private Button button_Process;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button button_Single;
        private Button button_Clear;
    }
}
