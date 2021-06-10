using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using WinS7Data.DataLibrary.Models;

namespace WinS7Data.DataModel
{
    public static class DeserializerForMvc
    {
        public static DatHE DeserializeDatHE(string path)
        {
            //create instance
            DatHE HE = new DatHE();
            try
            {
                // Deserialize from XML to the object
                XmlSerializer deserializer = new XmlSerializer(typeof(DatHE));
                TextReader reader = new StreamReader(path + " \\HE.xml");
                object obj = deserializer.Deserialize(reader);
                HE = (DatHE)obj;
                reader.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString() + " " + path + " \\HE.xml";
                //throw;
            }
            //return value
            return HE;
        }

        public static DatConfig DeserializeDatConfig(string path)
        {
            //create instance
            DatConfig Config = new DatConfig();
            try
            {
                // Deserialize from XML to the object
                XmlSerializer deserializer = new XmlSerializer(typeof(DatConfig));
                TextReader reader = new StreamReader(path + " \\Config.xml");
                object obj = deserializer.Deserialize(reader);
                Config = (DatConfig)obj;
                reader.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString() + " " + path + " \\Config.xml";
                //throw;
            }
            //return value
            return Config;
        }

        public static DatN2 DeserializeDatN2(string path)
        {
            //create instance
            DatN2 N2 = new DatN2();
            try
            {
                // Deserialize from XML to the object
                XmlSerializer deserializer = new XmlSerializer(typeof(DatN2));
                TextReader reader = new StreamReader(path + " \\N2.xml");
                object obj = deserializer.Deserialize(reader);
                N2 = (DatN2)obj;
                reader.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString() + " " + path + " \\N2.xml";
                //throw;
            }
            //return value
            return N2;
        }

        public static DatWerkzeug DeserializeDatWerkzeug(string path)
        {
            //create instance
            DatWerkzeug Werkzeug = new DatWerkzeug();
            try
            {
                // Deserialize from XML to the object
                XmlSerializer deserializer = new XmlSerializer(typeof(DatWerkzeug));
                TextReader reader = new StreamReader(path + " \\Werkzeug.xml");
                object obj = deserializer.Deserialize(reader);
                Werkzeug = (DatWerkzeug)obj;
                reader.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString() + " " + path + " \\Werkzeug.xml";
                //throw;
            }
            //return value
            return Werkzeug;
        }

        public static DatMWerkzeug DeserializeMWerkzeug(string path, string machineID)
        {
            //create instance
            DatMWerkzeug MWerkzeug = new DatMWerkzeug();
            try
            {
                // Deserialize from XML to the object
                XmlSerializer deserializer = new XmlSerializer(typeof(DatMWerkzeug));
                TextReader reader = new StreamReader(path + " \\MWerkzeug_" + machineID + ".xml");
                object obj = deserializer.Deserialize(reader);
                MWerkzeug = (DatMWerkzeug)obj;
                reader.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString() + " " + path + " \\MWerkzeug_" + machineID + ".xml";
                //throw;
            }
            //return value
            return MWerkzeug;
        }


        public static string[] GetSubDirectories(string root)
        {
            //root = @"E:\Recipes";
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(root);
            return subdirectoryEntries;
        }


        public static string[] GetFilesInDirectory(string root)
        {
            string[] fileEntries = Directory.GetFiles(root);
            return fileEntries;
        }

        public static bool GetFileByName(string root, string filename)
        {
            bool paramOK = false;
            string[] fileEntries = GetFilesInDirectory(root);
            foreach (string file in fileEntries)
            {
                if (file.Contains(filename))
                {
                    paramOK = true;
                }
            }
            return paramOK;
        }


        public static List<Recipe> DeserializeRecipes(string[] subdirectoryEntries)
        {
            List<Recipe> recipes = new List<Recipe>();
            string s1 = string.Empty;
            string s2 = string.Empty;

            foreach (string subdirectory in subdirectoryEntries)
            {
                Recipe recipe = new Recipe();

                if (subdirectory.Length >= 14)
                {
                    s1 = subdirectory.Substring(11, 3);
                    s2 = string.Empty;
                }

                if (subdirectory.Length >= 16)
                {
                    s2 = subdirectory.Substring(15);
                    s1 = subdirectory.Substring(11, 3);
                }

                // Parse ToolCode and ToolName
                recipe.ToolCode = s1.ParseShort();
                recipe.ToolName = s2;

                // DeserializeDatHE
                if (GetFileByName(subdirectory, "HE.xml"))
                {
                    recipe.DatHE = DeserializeDatHE(subdirectory);
                    recipe.DatHE.ToolCode = recipe.ToolCode;
                    recipe.DatHE.ToolName = recipe.ToolName;
                }
                else
                {
                    recipe.DatHE = new DatHE();
                    recipe.DatHE.ToolCode = recipe.ToolCode;
                    recipe.DatHE.ToolName = recipe.ToolName;
                }

                // DeserializeDatConfig
                if (GetFileByName(subdirectory, "Config.xml"))
                {
                    recipe.DatConfig = DeserializeDatConfig(subdirectory);
                    recipe.DatConfig.ToolCode = recipe.ToolCode;
                    recipe.DatConfig.ToolName = recipe.ToolName;
                }
                else
                {
                    recipe.DatConfig = new DatConfig();
                    recipe.DatConfig.ToolCode = recipe.ToolCode;
                    recipe.DatConfig.ToolName = recipe.ToolName;
                }

                // DeserializeDatN2
                if (GetFileByName(subdirectory, "N2.xml"))
                {
                    recipe.DatN2 = DeserializeDatN2(subdirectory);
                    recipe.DatN2.ToolCode = recipe.ToolCode;
                    recipe.DatN2.ToolName = recipe.ToolName;
                }
                else
                {
                    recipe.DatN2 = new DatN2();
                    recipe.DatN2.ToolCode = recipe.ToolCode;
                    recipe.DatN2.ToolName = recipe.ToolName;
                }

                // DeserializeDatWerkzeug
                if (GetFileByName(subdirectory, "Werkzeug.xml"))
                {
                    recipe.DatWerkzeug = DeserializeDatWerkzeug(subdirectory);
                    recipe.DatWerkzeug.ToolCode = recipe.ToolCode;
                    recipe.DatWerkzeug.ToolName = recipe.ToolName;
                }
                else
                {
                    recipe.DatWerkzeug = new DatWerkzeug();
                    recipe.DatWerkzeug.ToolCode = recipe.ToolCode;
                    recipe.DatWerkzeug.ToolName = recipe.ToolName;
                }

                #region DeserializeMWerkzeug 54XXX
                // DeserializeMWerkzeug 54030
                if (GetFileByName(subdirectory, "Werkzeug_54030.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54030");
                    mwerkzeug.MachineId = 54030;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54030;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54040
                if (GetFileByName(subdirectory, "Werkzeug_54040.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54040");
                    mwerkzeug.MachineId = 54040;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54040;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54050
                if (GetFileByName(subdirectory, "Werkzeug_54050.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54050");
                    mwerkzeug.MachineId = 54050;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54050;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54060
                if (GetFileByName(subdirectory, "Werkzeug_54060.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54060");
                    mwerkzeug.MachineId = 54060;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54060;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54070
                if (GetFileByName(subdirectory, "Werkzeug_54070.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54070");
                    mwerkzeug.MachineId = 54070;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54070;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54080
                if (GetFileByName(subdirectory, "Werkzeug_54080.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54080");
                    mwerkzeug.MachineId = 54080;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54080;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54090
                if (GetFileByName(subdirectory, "Werkzeug_54090.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54090");
                    mwerkzeug.MachineId = 54090;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54090;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }

                // DeserializeMWerkzeug 54100
                if (GetFileByName(subdirectory, "Werkzeug_54100.xml"))
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug = DeserializeMWerkzeug(subdirectory, "54100");
                    mwerkzeug.MachineId = 54100;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                else
                {
                    DatMWerkzeug mwerkzeug = new DatMWerkzeug();
                    mwerkzeug.MachineId = 54100;
                    mwerkzeug.ToolCode = recipe.ToolCode;
                    mwerkzeug.ToolName = recipe.ToolName;
                    recipe.DatMWerkzeugs.Add(mwerkzeug);
                }
                #endregion

                recipes.Add(recipe);
            }

            return recipes;
        }


        public static List<Recipe> GetRecipesFromFolder()
        {
            //string startupPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            //string recipesRoot = startupPath + @"\\Recipes";
            string recipesRoot = @"E:\Recipes";
            string[] subdirectories;
            subdirectories = GetSubDirectories(recipesRoot);

            List<Recipe> recipes = DeserializeRecipes(subdirectories);

            return recipes;
        }
    }
}
