using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project1_SAD
{
    class SchoolFile
    {
        private readonly string path;
        StreamWriter writer;
        public SchoolFile()
        {
            path = @"C:\School.txt";
           
        }

        public void AddNewItem(int id,string _class,string section)
        {
            writer = File.AppendText(path);
            string value = id+"-"+_class+"-"+section+"\n";
            writer.Write(value);
            
            Console.WriteLine("Added Done");
            writer.Close();
        }


        public School GetSchool(int id)
        {
            string[] lines = File.ReadAllLines(path);
            foreach(string s in lines)
            {
                string[] line = s.Split("-");
                if (int.Parse(line[0]) == id)
                {
                    School school = new School(int.Parse(line[0]), line[1], line[2]);
                    return school;
                }

            }

            return null;
        }

        public void update(int oldID,int id,string _class,string section)
        {
            string[] lines = File.ReadAllLines(path);
            bool status = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split("-");
                if (int.Parse(line[0]) == oldID)
                {
                    lines[i] = id + "-" + _class + "-" + section;
                    status = true;
                }
            }
            if (status)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine("Update is Doen!");
            }
           

        }

        
    }
}
