using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class DefaultExam : Exam,IListInfoGetter,IListInfoGet
    {
        public DefaultExam()
        {
            StudList = new List<Student>();
        }

        public List<Student> StudList
        {
            get;
            set;
        }

        List<string> info;
       
        List<string> IListInfoGetter.GetInfoFromList()
        {

            info = new List<string>();
            StudList.ForEach(st => info.Add("Fio:" + st.Fio + "  Date: " + st.Date + " Mark: " + st.Mark + " Questions: " + st.Questions));
            return info;
        }

        public List<string> GetStudInfo()
        {
            return ((IListInfoGetter)this).GetInfoFromList();
        }

        List<string> IListInfoGet.GetInfoFromList()
        {

            info = new List<string>();
            StudList.ForEach(st => info.Add("Fio: " + st.Fio + "  Date: " + st.Date + "   Mark: " + st.Mark + " Questions: " + st.Questions));
            return info;
        }

        public List<string> PickStudInfo()
        {
            return ((IListInfoGet)this).GetInfoFromList();
        }

        public void RemoveStud(int index)
        {
            StudList.Remove(StudList[index]);
        }

        
    }
}
