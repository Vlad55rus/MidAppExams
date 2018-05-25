using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Student
    {
        protected string fio;
        protected int mark;
        protected string questions;
        protected string date;

        [NonSerialized]
        protected string dateOfCreate; //Устанавливать текущую

        public Student(string fio,string date, int mark,string questions)
        {
            this.fio = fio;
            this.date = date;
            this.mark = mark;
            this.questions = questions;
        }

        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string DateOfCreate
        {
            get { return dateOfCreate; }
            set { dateOfCreate = value; }
        }

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Questions
        {
            get { return questions; }
            set { questions = value; }
        }
    }
}
