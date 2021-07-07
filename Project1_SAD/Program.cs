using System;

namespace Project1_SAD
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolFile school = new SchoolFile();
            Console.WriteLine("\t-----Welcome in the School System-----");
            bool status = true;
            while (status)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" 1-Add New Data in System \n 2-Search in The System \n 3-Update Data \n 4-Exit");
                Console.ForegroundColor = ConsoleColor.White;
                int? chose = null;
                try {
                    int cho = int.Parse(Console.ReadLine());
                    chose = cho;
                }catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter The Number for Chose");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                switch (chose)
                {
                    case 1:
                       
                        try
                        {
                            Console.WriteLine("Please Enter ID");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please Class Name");
                            string _class = Console.ReadLine();
                            Console.WriteLine("Please Enter Section Name");
                            string section = Console.ReadLine();
                            school.AddNewItem(id, name,_class, section);
                            
                        }
                        catch(Exception e)
                    {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter The Number for ID ");
                            Console.ForegroundColor = ConsoleColor.White;
                    }
                       
                      


                        break;

                    case 2:
                        Console.WriteLine("Please Enter the ID How wint to search");
                        int search_id = int.Parse(Console.ReadLine());
                        School sch = school.GetSchool(search_id);
                        if (sch != null)
                        {
                            Console.WriteLine($"The ID: {sch.ID}\nThe Name: {sch.Name}\nThe Class: {sch._class}\nThe Section: {sch.section}");
                        }
                        else
                        {
                            Console.WriteLine("Nothig ID in the file");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please Enter the ID How wint to search");
                        int id_search = int.Parse(Console.ReadLine());
                        School schoo = school.GetSchool(id_search);
                        if (schoo != null)
                        {
                            Console.WriteLine($"The ID: {schoo.ID}\nTheName: {schoo.Name}\nThe Class: {schoo._class}\nThe Section: {schoo.section}");
                            int old_id = schoo.ID;
                            Console.WriteLine("Please Enter new ID");
                            int new_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter new Name ");
                            string new_name = Console.ReadLine();
                            Console.WriteLine("Please Enter new Class");
                            string new_class = Console.ReadLine();
                            Console.WriteLine("Please Enter new Section");
                            string new_section = Console.ReadLine();
                            school.update(old_id, new_id, new_name,new_class, new_section);
                        }
                        else
                        {
                            Console.WriteLine("Can not foun any data in this id " + id_search);
                        }
                        break;
                    case 4:
                        status = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plase chose 1 to 4 ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                }
            }
        }
    }
}
