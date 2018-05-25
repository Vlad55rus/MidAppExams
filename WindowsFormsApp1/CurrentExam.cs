using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CurrentExamForm : Form
    {
        private string nameExam;
        private DefaultExam de;
        private EditForm ef;

        public CurrentExamForm(string nameExam, DefaultExam de)
        {
            this.nameExam = nameExam;
            this.de = de;
            InitializeComponent();
        }

        private void CurrentExamForm_Load(object sender, EventArgs e)
        {
            label1.Text = nameExam;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ef = new EditForm(this, de);
            ef.Show();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (de.StudList.Count == 0)
                MessageBox.Show("Nothing to show", "Notification", MessageBoxButtons.OK);
            else
            {
                dataGridView1.Rows.Add(de.StudList.Count);
                for (int i = 0; i < de.StudList.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = de.StudList[i].Fio;
                    dataGridView1.Rows[i].Cells[1].Value = de.StudList[i].Mark;
                    dataGridView1.Rows[i].Cells[2].Value = de.StudList[i].Date;
                    dataGridView1.Rows[i].Cells[3].Value = de.StudList[i].Questions;
                }
            }
        }

        private void CurrentExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close? Save it first", "Close", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                if (item.Index != 0)
                    de.StudList.RemoveAt(item.Index + 1);
            }
        }
    }
}
