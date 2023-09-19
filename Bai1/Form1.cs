using Bai1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        Subject subject = new Subject();
        List<string> list = new List<string>();

        double[] score = {0,0,0};
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?",
                                "Yes or No",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_AddToList_Click(object sender, EventArgs e)
        {
            if (!this.check_input_textbox_score())
            {
                MessageBox.Show("Bạn phải nhập điểm chính xác!");
                return;
            }

            string subject = this.comboBox_list_subject.Text;
            string tc = this.textBox_numberTC.Text;
            string sc = this.textBox_Score.Text;

            string add = subject + "-" 
                            + tc + "-"
                                + sc;
            this.list.Add(add);
            this.listBox_subject.DataSource = null;
            this.listBox_subject.DataSource = this.list;
            //this.listBox_subject.Refresh();

            this.score[0] += double.Parse(tc);
            this.score[1] += (double.Parse(sc) * double.Parse(tc));
        }

        private void comboBox_list_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.comboBox_list_subject.Text;
            this.textBox_numberTC.Text = this.subject.TC(name).ToString();
            this.textBox_Score.Text = "";
        }

        private bool check_input_textbox_score()
        {
            string input = this.textBox_Score.Text;
            if (double.TryParse(input,out double r))
            {
                return true;
            }
            else return false;
        }

        private void button_math_Click(object sender, EventArgs e)
        {
            if(this.listBox_subject.Items.Count == 0)
            {
                MessageBox.Show("Bạn phải nhập thêm môn học");
            }
            else
            {
                math();
            }
        }

        private void math()
        {
            this.score[2] = this.score[1] / this.score[0];
            this.textBox_numberTC_sum.Text = this.score[0].ToString();
            this.textBox_score_sum.Text = this.score[1].ToString("#.#"); 
            this.textBox_score_arg.Text = this.score[2].ToString("#.#");
        }
    }
}
