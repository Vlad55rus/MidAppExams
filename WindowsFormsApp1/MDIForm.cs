using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MDIForm : Form
    {
        BinaryFormatter formatter = new BinaryFormatter();
        CurrentExamForm cef, cef2, cef3;
        DefaultExam progex, mathex, engex;
        String repo,repo2,repo3;

        public MDIForm()
        {
            InitializeComponent();
        }

        private void oOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cef == null)
            {
                progex = new DefaultExam();
                cef = new CurrentExamForm("OOP", progex);
                cef.MdiParent = this;
                cef.Text = "OOP";
                cef.FormClosed += Cef_FormClosed;
                cef.Show();
            }
            else
                cef.Activate();
        }

        private void Cef_FormClosed(object sender, FormClosedEventArgs e)
        {
            cef = null;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm closing!", "Exams",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                  System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

        }

        private void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close the app?", "Close", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void mathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cef2 == null)
            {
                mathex = new DefaultExam();
                cef2 = new CurrentExamForm("Math", mathex);
                cef2.MdiParent = this;
                cef2.Text = "Math";
                cef2.FormClosed += Cef2_FormClosed;
                cef2.Show();
            }
            else
                cef2.Activate();
        }

        private void Cef2_FormClosed(object sender, FormClosedEventArgs e)
        {
            cef2 = null;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cef3 == null)
            {
                engex = new DefaultExam();
                cef3 = new CurrentExamForm("English", engex);
                cef3.MdiParent = this;
                cef3.Text = "English";
                cef3.FormClosed += Cef3_FormClosed;
                cef3.Show();
            }
            else
                cef3.Activate();
        }

        private void Cef3_FormClosed(object sender, FormClosedEventArgs e)
        {
            cef3 = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != "")
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                    {
                        if (progex?.StudList != null)
                        {
                            repo = sfd.FileName;
                            formatter.Serialize(fs, progex.StudList);
                        }
                    }
                    using (FileStream fs1 = new FileStream(sfd.FileName + "_1", FileMode.OpenOrCreate))
                    {
                        if (mathex?.StudList != null)
                        {
                            repo2 = sfd.FileName + "_1";
                            formatter.Serialize(fs1, mathex.StudList);
                        }
                    }
                    using (FileStream fs2 = new FileStream(sfd.FileName + "_2", FileMode.OpenOrCreate))
                    {
                        if (engex?.StudList != null)
                        {
                            repo3 = sfd.FileName + "_2";
                            formatter.Serialize(fs2, engex.StudList);
                        }
                    }

                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            Stream stream1 = null;
            Stream stream2 = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bat files (*.bat)|*.bat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = ofd.OpenFile()) != null)
                    {
                        stream1 = File.Open(repo2, FileMode.Open);
                        stream2 = File.Open(repo3, FileMode.Open);

                        List<Student> stList = (List<Student>)formatter.Deserialize(stream); 
                        List<Student> stList1 = (List<Student>)formatter.Deserialize(stream1);
                        List<Student> stList2 = (List<Student>)formatter.Deserialize(stream2);

                        foreach (Student st in stList)
                        {
                            st.DateOfCreate = DateTime.Now.ToString();
                            progex.StudList.Add(st);
                        }
                        foreach (Student st in stList1)
                        {
                            st.DateOfCreate = DateTime.Now.ToString();
                            mathex.StudList.Add(st);
                        }
                        foreach (Student st in stList2)
                        {
                            st.DateOfCreate = DateTime.Now.ToString();
                            engex.StudList.Add(st);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
    }
}
