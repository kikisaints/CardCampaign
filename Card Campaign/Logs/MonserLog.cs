using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Card_Campaign.Logs
{
    class MonsterInfo
    {
        public class AbilitiesAndActions
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

        public string name;
        public List<string> tagList = new List<string>();
         
        public string sizeAndtype;
        public string alignment;
         
        public string AC;
        public string HP;
        public string speed;
         
        public int STR;
        public int DEX;
        public int CON;
        public int INT;
        public int WIS;
        public int CHA;

        public List<AbilitiesAndActions> abilitiesAndActions = new List<AbilitiesAndActions>();
    }

    class MonsterLog
    {
        public List<MonsterInfo> monsterDictionary = new List<MonsterInfo>();
        public int currentMonstersLoaded = 0;
        public string lastLoadedMonster = "";
                
        public MonsterLog(Card_Campaign.LoadingPage lPage)
        {
            string line;

            string path = @"Assets\Bestiary";

            //String[] files = System.IO.Directory.GetFiles(@"C:\Users\Public\Pictures\Sample Pictures", "*.jpg");
            //String newDir = @"C:\Users\Public\Pictures\Sample Pictures\Modified";
            //System.IO.Directory.CreateDirectory(newDir);

            //foreach (string fileName in Directory.GetFiles(path))
            //string[] dirFiles = Directory.GetFiles(path);
            //Parallel.ForEach(dirFiles, fileName =>
            foreach (string fileName in Directory.GetFiles(path))
            {
                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);

                MonsterInfo tempMonsterInfo = new MonsterInfo();
                bool sizealignSet = false;
                bool ACSet = false;
                bool HPSet = false;
                bool speedSet = false;
                bool statsSet = false;
                bool actionsAbilities = false;

                while ((line = file.ReadLine()) != null)
                {
                    if (line == "" || line == null)
                        continue;

                    string[] pieces = {"" };
                    //remove all the markdown indicators
                    if (line != null)
                    {
                        line = line.Replace("\"", "");
                        line = line.Replace("[", "");
                        line = line.Replace("]", "");

                        pieces = line.Split(':');
                    }

                    try
                    {
                        if (pieces[0] == "title")
                        {
                            tempMonsterInfo.name = pieces[1];
                        }
                        if (pieces[0] == "tags")
                        {
                            pieces[1] = pieces[1].Replace(" ", "");
                            string[] tags = pieces[1].Split(",");

                            for (int i = 0; i < tags.Length; i++)
                                tempMonsterInfo.tagList.Add(tags[i]);
                        }

                        pieces = line.Split("**");

                        if (!sizealignSet && pieces[0] == "" && pieces.Length > 1)
                        {
                            pieces[1].Replace(" ", "");
                            string[] linePieces = pieces[1].Split(",");

                            sizealignSet = true;
                            tempMonsterInfo.sizeAndtype = linePieces[0];

                            tempMonsterInfo.alignment = GetAlignmentAbbreviation(linePieces[1]);

                            //Uncomment break to NOT add in stats, disc, etc.
                            //break;
                        }
                        else if (!ACSet && pieces[0] == "" && pieces.Length > 1)
                        {
                            ACSet = true;
                            char[] noBeginningSpace = pieces[2].ToCharArray();

                            for (int i = 1; i < noBeginningSpace.Length; i++)
                            {
                                tempMonsterInfo.AC += noBeginningSpace[i];
                            }
                        }
                        else if (!HPSet && pieces[0] == "" && pieces.Length > 1)
                        {
                            HPSet = true;
                            char[] noBeginningSpace = pieces[2].ToCharArray();

                            for (int i = 1; i < noBeginningSpace.Length; i++)
                            {
                                tempMonsterInfo.HP += noBeginningSpace[i];
                            }
                        }
                        else if (!speedSet && pieces[0] == "" && pieces.Length > 1)
                        {
                            speedSet = true;
                            char[] noBeginningSpace = pieces[2].ToCharArray();

                            for (int i = 1; i < noBeginningSpace.Length; i++)
                            {
                                tempMonsterInfo.speed += noBeginningSpace[i];
                            }
                        }
                        else if (!statsSet && line[0] == '|')
                        {
                            string replaced = line.Replace(" ", "");
                            string[] statPieces = replaced.Split("|");

                            foreach (string s in statPieces)
                            {
                                string stat = "";
                                foreach (char c in s)
                                {
                                    if (c != '(')
                                        stat += c;
                                    else
                                        break;
                                }
                                if (tempMonsterInfo.STR == 0)
                                {
                                    Int32.TryParse(stat, out tempMonsterInfo.STR);
                                }
                                else if (tempMonsterInfo.DEX == 0)
                                {
                                    Int32.TryParse(stat, out tempMonsterInfo.DEX);
                                }
                                else if (tempMonsterInfo.CON == 0)
                                {
                                    Int32.TryParse(stat, out tempMonsterInfo.CON);
                                }
                                else if (tempMonsterInfo.INT == 0)
                                {
                                    Int32.TryParse(stat, out tempMonsterInfo.INT);
                                }
                                else if (tempMonsterInfo.WIS == 0)
                                {
                                    Int32.TryParse(stat, out tempMonsterInfo.WIS);
                                }
                                else if (tempMonsterInfo.CHA == 0)
                                {
                                    Int32.TryParse(stat, out tempMonsterInfo.CHA);
                                    statsSet = true;
                                }
                            }
                        }
                        else if (!actionsAbilities && sizealignSet && ACSet && HPSet && speedSet && statsSet)
                        {
                            if (pieces.Length > 1)
                            {
                                if (pieces[1][0] == '*')
                                {
                                    string subtitle = pieces[1].Replace("*", "");
                                    subtitle = subtitle.Replace(".", ":");

                                    string discription = pieces[2].Replace("*", "");
                                    tempMonsterInfo.abilitiesAndActions.Add(new MonsterInfo.AbilitiesAndActions("", subtitle, discription));
                                }
                                else
                                {
                                    tempMonsterInfo.abilitiesAndActions.Add(new MonsterInfo.AbilitiesAndActions(pieces[1], "", pieces[2]));
                                }
                            }
                            else if (pieces[0].Contains(":"))
                            {
                                string[] bulletPoints = pieces[0].Split(":");
                                string discription = bulletPoints[1].Replace("*", "");
                                string subtitle = bulletPoints[0].Replace("*", "");
                                tempMonsterInfo.abilitiesAndActions.Add(new MonsterInfo.AbilitiesAndActions("", subtitle + " -", discription));
                            }
                            else if (pieces[0].Length > 1 && pieces[0][0] != '|')
                            {
                                string discription = pieces[0].Replace("*", "");
                                tempMonsterInfo.abilitiesAndActions.Add(new MonsterInfo.AbilitiesAndActions("", "", discription));
                            }
                        }
                    }
                    catch
                    {
                        //If anything failed to index correctly, just forget it and move on, it's probably just a space or blank file anywho
                    }
                }
                file.Close();

                monsterDictionary.Add(tempMonsterInfo);
                ++currentMonstersLoaded;
                lPage.UpdateLoadingText(tempMonsterInfo.name);
            }//);   
        }

        public MonsterInfo UpdateBeastiary(int beastIndex)
        {
            if(beastIndex >= 0)
                return monsterDictionary[beastIndex];

            return null;
        }

        private string GetAlignmentAbbreviation(string align)
        {
            switch(align)
            {
                case " lawful good":
                    align = "LG"; break;
                case " neutral good":
                    align = "NG"; break;
                case " chaotic good":
                    align = "CG"; break;

                case " lawful neutral":
                    align = "LN"; break;
                case " neutral":
                    align = "N"; break;
                case " chaotic neutral":
                    align = "CN"; break;

                case " lawful evil":
                    align = "LE"; break;
                case " neutral evil":
                    align = "NE"; break;
                case " chaotic evil":
                    align = "CE"; break;

                default:
                    align = "U"; break;
            }

            return align;
        }
    }
}
