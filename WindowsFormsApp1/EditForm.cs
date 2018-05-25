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
    public partial class EditForm : Form
    {
        DefaultExam de;
        Form f;
        int mark;

        public EditForm(Form f, DefaultExam de)
        {
            this.f = f;
            this.de = de;
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           
            if (fioTextBox.Text != null && markTextBox.Text != null && dateTextBox.Text != null && ticketTextBox.Text != null)
            {
                Student st = new Student(fioTextBox.Text, dateTextBox.Text, mark, ticketTextBox.Text);
                de.StudList.Add(st);
            }
            else
                MessageBox.Show("Fill all the fields please", "Notification", MessageBoxButtons.OK);

            this.Hide();
            f.Show();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            dateTextBox.Text = DateTime.Now.ToString();
        }

        private void markTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                mark = Int16.Parse(markTextBox.Text);
                if (mark > 5 || mark < 2)
                {
                    MessageBox.Show("Mark should be 2--5,no less no more","Oops",MessageBoxButtons.OK);
                    markTextBox.Clear();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Not a number!", "EditForm", MessageBoxButtons.OK);
                markTextBox.Clear();
            }
        }
    }
}
