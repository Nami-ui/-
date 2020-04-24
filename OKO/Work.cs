using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace OKO
{
    public class Work
    {
        public static string FilePath;
        //public static string error = "F:\\Cursovay\\e.png";

        public static List<string> ReadLines()
        {
            return File.ReadAllLines(FilePath).ToList();
        }

        public static void SaveFile(List<string> list)
        {
            File.WriteAllLines(FilePath, list.ToArray());
        }

        public static string ReadLine(int id)
        {
            List<string> lst = ReadLines();
            string st = "";
            foreach (string s in lst)
            {
                if (s.StartsWith(id.ToString() + ";"))
                {
                    st = s;
                    break;
                }
            }
            return st;
        }

        public static void AddUpd(int id, string name, int age, string work, string pic)
        {
            List<string> list = ReadLines();
            if (id == 0)
            {
                foreach (string s in list.ToArray())
                {
                    string[] ss = s.Split(';');
                    if (Convert.ToInt32(ss[0]) > id)
                    {
                        id = Convert.ToInt32(ss[0]);
                    }
                }
                id++;
                string st = id.ToString() + ";" + name + ";" + age.ToString() + ";" + work + ";" + error;
                list.Add(st);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].StartsWith(id.ToString() + ";"))
                    {
                        list[i] = id.ToString() + ";" + name + ";" + age.ToString() + ";" + work + ";" + pic;
                        break;
                    }
                }
            }
            SaveFile(list);
        }

        public static void Del(int id)
        {
            List<string> list = ReadLines();

            string st = ReadLine(id);
            list.Remove(st);
            SaveFile(list);
        }

        public static DataTable Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Номер");
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Возраст");
            dt.Columns.Add("Должность");

            List<string> lst = ReadLines();
            foreach (string s in lst)
            {
                string[] ss = s.Split(';');
                dt.Rows.Add(ss[0], ss[1], ss[2], ss[3]);
            }
            return dt;
        }
    }
}