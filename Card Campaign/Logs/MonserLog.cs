using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Campaign.Logs
{
    class MonsterInfo
    {
        class AbilitiesAndActions
        {
            public AbilitiesAndActions(string t, string subt, string disc)
            {
                title = t;
                subtitle = subt;
                discription = disc;
            }

            public string title;
            public string subtitle;
            public string discription;
        }

        string name;
        List<string> tagList = new List<string>();

        string size;
        string type;
        string alignment;

        int AC;
        int HP;
        List<string> speed = new List<string>();

        int STR;
        int DEX;
        int CON;
        int INT;
        int WIS;
        int CHA;

        List<AbilitiesAndActions> abilitiesAndActions = new List<AbilitiesAndActions>();
    }

    class MonsterLog
    {
        List<MonsterInfo> monsterDictionary = new List<MonsterInfo>();

        public MonsterLog()
        {
            int counter = 0;
            string line;

            string path = @"Assets\";
            foreach (string fileName in Directory.GetFiles(path))
            {
                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
                file.Close();
            }            
        }
    }
}
