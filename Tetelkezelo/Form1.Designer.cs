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
            this.filter_subject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filter_title = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.view_essay = new System.Windows.Forms.Button();
            this.view_draft = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.read_panel = new System.Windows.Forms.Panel();
            this.upload_panel.SuspendLayout();
            this.read_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upload.Location = new System.Drawing.Point(771, 0);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(726, 122);
            this.upload.TabIndex = 1;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // upload_panel
            // 
            this.upload_panel.BackColor = System.Drawing.Color.Transparent;
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
            this.upload_panel.Location = new System.Drawing.Point(495, 128);
            this.upload_panel.Name = "upload_panel";
            this.upload_panel.Size = new System.Drawing.Size(567, 376);
            this.upload_panel.TabIndex = 2;
            // 
            // uploadData
            // 
            this.uploadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadData.Location = new System.Drawing.Point(444, 312);
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
            this.essay_file.Location = new System.Drawing.Point(97, 231);
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
            this.draft_file.Location = new System.Drawing.Point(97, 135);
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
            this.label4.Location = new System.Drawing.Point(19, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Essay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Draft";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(343, 57);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(209, 32);
            this.TitleComboBox.TabIndex = 5;
            this.TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleTextBox.Location = new System.Drawing.Point(82, 58);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(245, 29);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 62);
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
            this.SubjectComboBox.Location = new System.Drawing.Point(343, 5);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(209, 32);
            this.SubjectComboBox.TabIndex = 2;
            this.SubjectComboBox.SelectedIndexChanged += new System.EventHandler(this.SubjectComboBox_SelectedIndexChanged);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectTextBox.Location = new System.Drawing.Point(82, 6);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(245, 29);
            this.subjectTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // filter_subject
            // 
            this.filter_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filter_subject.FormattingEnabled = true;
            this.filter_subject.Location = new System.Drawing.Point(82, 3);
            this.filter_subject.Name = "filter_subject";
            this.filter_subject.Size = new System.Drawing.Size(209, 32);
            this.filter_subject.TabIndex = 13;
            this.filter_subject.SelectedIndexChanged += new System.EventHandler(this.filter_subject_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subject";
            // 
            // filter_title
            // 
            this.filter_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filter_title.FormattingEnabled = true;
            this.filter_title.Location = new System.Drawing.Point(82, 56);
            this.filter_title.Name = "filter_title";
            this.filter_title.Size = new System.Drawing.Size(209, 32);
            this.filter_title.TabIndex = 16;
            this.filter_title.SelectedIndexChanged += new System.EventHandler(this.filter_title_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Title";
            // 
            // view_essay
            // 
            this.view_essay.AutoSize = true;
            this.view_essay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.view_essay.Location = new System.Drawing.Point(91, 167);
            this.view_essay.Name = "view_essay";
            this.view_essay.Size = new System.Drawing.Size(164, 34);
            this.view_essay.TabIndex = 20;
            this.view_essay.Text = "View";
            this.view_essay.UseVisualStyleBackColor = true;
            this.view_essay.Click += new System.EventHandler(this.view_essay_Click);
            // 
            // view_draft
            // 
            this.view_draft.AutoSize = true;
            this.view_draft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.view_draft.Location = new System.Drawing.Point(91, 127);
            this.view_draft.Name = "view_draft";
            this.view_draft.Size = new System.Drawing.Size(164, 34);
            this.view_draft.TabIndex = 19;
            this.view_draft.Text = "View";
            this.view_draft.UseVisualStyleBackColor = true;
            this.view_draft.Click += new System.EventHandler(this.view_draft_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Essay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(13, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Draft";
            // 
            // read_panel
            // 
            this.read_panel.BackColor = System.Drawing.Color.Transparent;
            this.read_panel.Controls.Add(this.view_essay);
            this.read_panel.Controls.Add(this.view_draft);
            this.read_panel.Controls.Add(this.label7);
            this.read_panel.Controls.Add(this.label8);
            this.read_panel.Controls.Add(this.filter_title);
            this.read_panel.Controls.Add(this.label6);
            this.read_panel.Controls.Add(this.filter_subject);
            this.read_panel.Controls.Add(this.label5);
            this.read_panel.Location = new System.Drawing.Point(184, 128);
            this.read_panel.Name = "read_panel";
            this.read_panel.Size = new System.Drawing.Size(296, 207);
            this.read_panel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 731);
            this.Controls.Add(this.read_panel);
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
            this.read_panel.ResumeLayout(false);
            this.read_panel.PerformLayout();
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
        private System.Windows.Forms.Button view_essay;
        private System.Windows.Forms.Button view_draft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filter_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox filter_subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel read_panel;
    }
}

