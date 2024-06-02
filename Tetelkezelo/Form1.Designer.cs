namespace Tetelkezelo
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
            if(disposing && (components != null))
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
            this.read = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.upload_panel = new System.Windows.Forms.Panel();
            this.uploadData = new System.Windows.Forms.Button();
            this.essay_file = new System.Windows.Forms.Button();
            this.draft_file = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.SystemColors.ControlDark;
            this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.read.Location = new System.Drawing.Point(0, 0);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(726, 122);
            this.read.TabIndex = 0;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upload.Location = new System.Drawing.Point(771, 0);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(726, 122);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // upload_panel
            // 
            this.upload_panel.Controls.Add(this.uploadData);
            this.upload_panel.Controls.Add(this.essay_file);
            this.upload_panel.Controls.Add(this.draft_file);
            this.upload_panel.Controls.Add(this.label4);
            this.upload_panel.Controls.Add(this.label3);
            this.upload_panel.Controls.Add(this.TitleComboBox);
            this.upload_panel.Controls.Add(this.TitleTextBox);
            this.upload_panel.Controls.Add(this.label2);
            this.upload_panel.Controls.Add(this.SubjectComboBox);
            this.upload_panel.Controls.Add(this.subjectTextBox);
            this.upload_panel.Controls.Add(this.label1);
            this.upload_panel.Location = new System.Drawing.Point(0, 128);
            this.upload_panel.Name = "upload_panel";
            this.upload_panel.Size = new System.Drawing.Size(1497, 605);
            this.upload_panel.TabIndex = 2;
            // 
            // uploadData
            // 
            this.uploadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadData.Location = new System.Drawing.Point(891, 417);
            this.uploadData.Name = "uploadData";
            this.uploadData.Size = new System.Drawing.Size(89, 40);
            this.uploadData.TabIndex = 10;
            this.uploadData.Text = "Upload";
            this.uploadData.UseVisualStyleBackColor = true;
            this.uploadData.Click += new System.EventHandler(this.uploadData_Click);
            // 
            // essay_file
            // 
            this.essay_file.AutoSize = true;
            this.essay_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.essay_file.Location = new System.Drawing.Point(525, 312);
            this.essay_file.Name = "essay_file";
            this.essay_file.Size = new System.Drawing.Size(164, 34);
            this.essay_file.TabIndex = 9;
            this.essay_file.Text = "select file...";
            this.essay_file.UseVisualStyleBackColor = true;
            this.essay_file.Click += new System.EventHandler(this.thesis_file_Click);
            // 
            // draft_file
            // 
            this.draft_file.AutoSize = true;
            this.draft_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draft_file.Location = new System.Drawing.Point(525, 216);
            this.draft_file.Name = "draft_file";
            this.draft_file.Size = new System.Drawing.Size(164, 34);
            this.draft_file.TabIndex = 8;
            this.draft_file.Text = "select file...";
            this.draft_file.UseVisualStyleBackColor = true;
            this.draft_file.Click += new System.EventHandler(this.draft_file_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(447, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Essay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(447, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Draft";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(771, 138);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(209, 32);
            this.TitleComboBox.TabIndex = 5;
            this.TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleTextBox.Location = new System.Drawing.Point(510, 139);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(245, 29);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(446, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(771, 86);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(209, 32);
            this.SubjectComboBox.TabIndex = 2;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectTextBox.Location = new System.Drawing.Point(510, 87);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(245, 29);
            this.subjectTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(431, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 731);
            this.Controls.Add(this.upload_panel);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Tetelkezelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.upload_panel.ResumeLayout(false);
            this.upload_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Panel upload_panel;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button essay_file;
        private System.Windows.Forms.Button draft_file;
        private System.Windows.Forms.Button uploadData;
    }
}

