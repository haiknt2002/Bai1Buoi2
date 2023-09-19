namespace Bai1
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
            this.groupBox_i4_student = new System.Windows.Forms.GroupBox();
            this.button_AddToList = new System.Windows.Forms.Button();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.textBox_numberTC = new System.Windows.Forms.TextBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_numberTC = new System.Windows.Forms.Label();
            this.comboBox_list_subject = new System.Windows.Forms.ComboBox();
            this.label_subject_name = new System.Windows.Forms.Label();
            this.groupBox_list_subject = new System.Windows.Forms.GroupBox();
            this.listBox_subject = new System.Windows.Forms.ListBox();
            this.textBox_score_sum = new System.Windows.Forms.TextBox();
            this.textBox_numberTC_sum = new System.Windows.Forms.TextBox();
            this.label_Score_sum = new System.Windows.Forms.Label();
            this.label_numerTC_sum = new System.Windows.Forms.Label();
            this.textBox_score_arg = new System.Windows.Forms.TextBox();
            this.label_score_arg = new System.Windows.Forms.Label();
            this.button_math = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_i4_student.SuspendLayout();
            this.groupBox_list_subject.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_i4_student
            // 
            this.groupBox_i4_student.Controls.Add(this.button_AddToList);
            this.groupBox_i4_student.Controls.Add(this.textBox_Score);
            this.groupBox_i4_student.Controls.Add(this.textBox_numberTC);
            this.groupBox_i4_student.Controls.Add(this.label_Score);
            this.groupBox_i4_student.Controls.Add(this.label_numberTC);
            this.groupBox_i4_student.Controls.Add(this.comboBox_list_subject);
            this.groupBox_i4_student.Controls.Add(this.label_subject_name);
            this.groupBox_i4_student.Location = new System.Drawing.Point(38, 35);
            this.groupBox_i4_student.Name = "groupBox_i4_student";
            this.groupBox_i4_student.Size = new System.Drawing.Size(362, 428);
            this.groupBox_i4_student.TabIndex = 0;
            this.groupBox_i4_student.TabStop = false;
            this.groupBox_i4_student.Text = "Thông tin điểm sinh viên";
            // 
            // button_AddToList
            // 
            this.button_AddToList.Location = new System.Drawing.Point(46, 333);
            this.button_AddToList.Name = "button_AddToList";
            this.button_AddToList.Size = new System.Drawing.Size(278, 49);
            this.button_AddToList.TabIndex = 6;
            this.button_AddToList.Text = "Thêm vào &danh sách";
            this.button_AddToList.UseVisualStyleBackColor = true;
            this.button_AddToList.Click += new System.EventHandler(this.button_AddToList_Click);
            // 
            // textBox_Score
            // 
            this.textBox_Score.Location = new System.Drawing.Point(197, 245);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(147, 36);
            this.textBox_Score.TabIndex = 5;
            // 
            // textBox_numberTC
            // 
            this.textBox_numberTC.Enabled = false;
            this.textBox_numberTC.Location = new System.Drawing.Point(197, 171);
            this.textBox_numberTC.Name = "textBox_numberTC";
            this.textBox_numberTC.ReadOnly = true;
            this.textBox_numberTC.Size = new System.Drawing.Size(147, 36);
            this.textBox_numberTC.TabIndex = 4;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(41, 252);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(80, 29);
            this.label_Score.TabIndex = 3;
            this.label_Score.Text = "Điểm:";
            // 
            // label_numberTC
            // 
            this.label_numberTC.AutoSize = true;
            this.label_numberTC.Location = new System.Drawing.Point(41, 178);
            this.label_numberTC.Name = "label_numberTC";
            this.label_numberTC.Size = new System.Drawing.Size(125, 29);
            this.label_numberTC.TabIndex = 2;
            this.label_numberTC.Text = "Số tín chỉ:";
            // 
            // comboBox_list_subject
            // 
            this.comboBox_list_subject.FormattingEnabled = true;
            this.comboBox_list_subject.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích F1",
            "Tiếng Anh A0",
            "Triết học Mác - Lênin",
            "Vật lý F1"});
            this.comboBox_list_subject.Location = new System.Drawing.Point(46, 105);
            this.comboBox_list_subject.Name = "comboBox_list_subject";
            this.comboBox_list_subject.Size = new System.Drawing.Size(298, 37);
            this.comboBox_list_subject.TabIndex = 1;
            this.comboBox_list_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox_list_subject_SelectedIndexChanged);
            // 
            // label_subject_name
            // 
            this.label_subject_name.AutoSize = true;
            this.label_subject_name.Location = new System.Drawing.Point(41, 51);
            this.label_subject_name.Name = "label_subject_name";
            this.label_subject_name.Size = new System.Drawing.Size(168, 29);
            this.label_subject_name.TabIndex = 0;
            this.label_subject_name.Text = "Tên môn học:";
            // 
            // groupBox_list_subject
            // 
            this.groupBox_list_subject.Controls.Add(this.listBox_subject);
            this.groupBox_list_subject.Location = new System.Drawing.Point(429, 35);
            this.groupBox_list_subject.Name = "groupBox_list_subject";
            this.groupBox_list_subject.Size = new System.Drawing.Size(589, 239);
            this.groupBox_list_subject.TabIndex = 1;
            this.groupBox_list_subject.TabStop = false;
            this.groupBox_list_subject.Text = "Danh sách các môn học";
            // 
            // listBox_subject
            // 
            this.listBox_subject.FormattingEnabled = true;
            this.listBox_subject.ItemHeight = 29;
            this.listBox_subject.Location = new System.Drawing.Point(18, 37);
            this.listBox_subject.Name = "listBox_subject";
            this.listBox_subject.Size = new System.Drawing.Size(556, 178);
            this.listBox_subject.TabIndex = 0;
            // 
            // textBox_score_sum
            // 
            this.textBox_score_sum.Enabled = false;
            this.textBox_score_sum.Location = new System.Drawing.Point(906, 284);
            this.textBox_score_sum.Name = "textBox_score_sum";
            this.textBox_score_sum.ReadOnly = true;
            this.textBox_score_sum.Size = new System.Drawing.Size(112, 36);
            this.textBox_score_sum.TabIndex = 10;
            // 
            // textBox_numberTC_sum
            // 
            this.textBox_numberTC_sum.Enabled = false;
            this.textBox_numberTC_sum.Location = new System.Drawing.Point(617, 284);
            this.textBox_numberTC_sum.Name = "textBox_numberTC_sum";
            this.textBox_numberTC_sum.ReadOnly = true;
            this.textBox_numberTC_sum.Size = new System.Drawing.Size(112, 36);
            this.textBox_numberTC_sum.TabIndex = 9;
            // 
            // label_Score_sum
            // 
            this.label_Score_sum.AutoSize = true;
            this.label_Score_sum.Location = new System.Drawing.Point(760, 287);
            this.label_Score_sum.Name = "label_Score_sum";
            this.label_Score_sum.Size = new System.Drawing.Size(140, 29);
            this.label_Score_sum.TabIndex = 8;
            this.label_Score_sum.Text = "Tổng điểm:";
            // 
            // label_numerTC_sum
            // 
            this.label_numerTC_sum.AutoSize = true;
            this.label_numerTC_sum.Location = new System.Drawing.Point(424, 287);
            this.label_numerTC_sum.Name = "label_numerTC_sum";
            this.label_numerTC_sum.Size = new System.Drawing.Size(185, 29);
            this.label_numerTC_sum.TabIndex = 7;
            this.label_numerTC_sum.Text = "Tổng số tín chỉ:";
            // 
            // textBox_score_arg
            // 
            this.textBox_score_arg.Enabled = false;
            this.textBox_score_arg.Location = new System.Drawing.Point(629, 339);
            this.textBox_score_arg.Name = "textBox_score_arg";
            this.textBox_score_arg.ReadOnly = true;
            this.textBox_score_arg.Size = new System.Drawing.Size(172, 36);
            this.textBox_score_arg.TabIndex = 12;
            // 
            // label_score_arg
            // 
            this.label_score_arg.AutoSize = true;
            this.label_score_arg.Location = new System.Drawing.Point(424, 342);
            this.label_score_arg.Name = "label_score_arg";
            this.label_score_arg.Size = new System.Drawing.Size(199, 29);
            this.label_score_arg.TabIndex = 11;
            this.label_score_arg.Text = "Điểm trung bình:";
            // 
            // button_math
            // 
            this.button_math.Location = new System.Drawing.Point(495, 409);
            this.button_math.Name = "button_math";
            this.button_math.Size = new System.Drawing.Size(170, 53);
            this.button_math.TabIndex = 13;
            this.button_math.Text = "Tính";
            this.button_math.UseVisualStyleBackColor = true;
            this.button_math.Click += new System.EventHandler(this.button_math_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(765, 409);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(170, 53);
            this.button_exit.TabIndex = 14;
            this.button_exit.Text = "T&hoát";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 493);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_math);
            this.Controls.Add(this.textBox_score_arg);
            this.Controls.Add(this.label_score_arg);
            this.Controls.Add(this.textBox_score_sum);
            this.Controls.Add(this.groupBox_list_subject);
            this.Controls.Add(this.textBox_numberTC_sum);
            this.Controls.Add(this.label_Score_sum);
            this.Controls.Add(this.groupBox_i4_student);
            this.Controls.Add(this.label_numerTC_sum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Quản lí sinh viên";
            this.groupBox_i4_student.ResumeLayout(false);
            this.groupBox_i4_student.PerformLayout();
            this.groupBox_list_subject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_i4_student;
        private System.Windows.Forms.GroupBox groupBox_list_subject;
        private System.Windows.Forms.Label label_subject_name;
        private System.Windows.Forms.ComboBox comboBox_list_subject;
        private System.Windows.Forms.Button button_AddToList;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.TextBox textBox_numberTC;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_numberTC;
        private System.Windows.Forms.TextBox textBox_score_sum;
        private System.Windows.Forms.TextBox textBox_numberTC_sum;
        private System.Windows.Forms.Label label_Score_sum;
        private System.Windows.Forms.Label label_numerTC_sum;
        private System.Windows.Forms.TextBox textBox_score_arg;
        private System.Windows.Forms.Label label_score_arg;
        private System.Windows.Forms.Button button_math;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ListBox listBox_subject;
    }
}

