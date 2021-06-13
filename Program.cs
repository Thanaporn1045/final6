using System;

namespace ข้อ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentfile = new string[5];
            for (int i = 0; i < currentfile.Length; i++)
            { currentfile[i] = " "; }
            Menu(currentfile);

        }
        static void Menu(string[] currentfile)
        {
            int page;
            do
            {
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                Console.WriteLine("[0] Show all recent files");
                Console.WriteLine("[1] Open new file");
                Console.WriteLine("[2] Open recent file");
                Console.WriteLine("[3] Exit");
                page = int.Parse(Console.ReadLine());
                if (page < 0 || page > 3) { Console.WriteLine("Invalid menu number."); }
            } while (page < 0 || page > 3);
            if (page == 0) { showfile(currentfile); }
            else if (page == 1) { newfile(currentfile); }
            else if (page == 2) { recentfile(currentfile); }
            else if (page == 3) { }
            else { Console.WriteLine("Invalid menu number."); }


        }
        static void showfile(string[] currentfile)
        {
            for (int i = 0; i < currentfile.Length; i++)
            { Console.WriteLine("[{0}] {1}", i, currentfile[i]); }
            Menu(currentfile);
        }
        static void newfile(string[] currentfile)
        {
            string name = Console.ReadLine();
            
            for(int i = 3 ; i>= 0 ;i--)
            {
                currentfile[i + 1] = currentfile[i];
            }
            currentfile[0] = name;
            Menu(currentfile);
        }
        static void recentfile(string[] currentfile)
        {
            int x = int.Parse(Console.ReadLine());
            if(currentfile[x]!=" ") 
            {
                string a = currentfile[x];
                currentfile[4] = " ";
                for (int i = 3; i >= 0; i--)
                {
                    currentfile[i + 1] = currentfile[i];
                }
                currentfile[0] = a;
                Menu(currentfile);
            }
            else { Console.WriteLine("No recent file"); Menu(currentfile); }
        }
    }
}
