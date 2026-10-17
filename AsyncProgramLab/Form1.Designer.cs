namespace AsyncProgramLab
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
            label1 = new Label();
            label2 = new Label();
            btnBrowse1 = new Button();
            btnBrowse2 = new Button();
            txtFileName1 = new TextBox();
            txtFileName2 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnExit = new Button();
            btnSubmit = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 0;
            label1.Text = "Book 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 87);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Book 2";
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(366, 80);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(150, 46);
            btnBrowse1.TabIndex = 2;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(970, 87);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(150, 46);
            btnBrowse2.TabIndex = 3;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // txtFileName1
            // 
            txtFileName1.Location = new Point(139, 84);
            txtFileName1.Name = "txtFileName1";
            txtFileName1.Size = new Size(200, 39);
            txtFileName1.TabIndex = 4;
            // 
            // txtFileName2
            // 
            txtFileName2.Location = new Point(717, 87);
            txtFileName2.Name = "txtFileName2";
            txtFileName2.Size = new Size(200, 39);
            txtFileName2.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(30, 171);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 388);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(552, 171);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(492, 388);
            listBox2.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(234, 624);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(587, 624);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 735);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(txtFileName2);
            Controls.Add(txtFileName1);
            Controls.Add(btnBrowse2);
            Controls.Add(btnBrowse1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBrowse1;
        private Button btnBrowse2;
        private TextBox txtFileName1;
        private TextBox txtFileName2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnExit;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}
