using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKO
{
    public class Worker
    {
        public int id;
        public string name;
        public int age;
        public string work;
        public string pic;

        public Worker()
        {
            id = 0;
            name = "";
            age = 0;
            work = "";
            pic = "";
        }

        public Worker(int id) : this()
        {
            string st = Work.ReadLine(id);
            string[] ss = st.Split(';');
            if (ss.Length > 1)
            {
                id = Convert.ToInt32(ss[0]);
                name = ss[1];
                age = Convert.ToInt32(ss[2]);
                work = ss[3];
                pic = ss[4];
            }
        }
    }
}
