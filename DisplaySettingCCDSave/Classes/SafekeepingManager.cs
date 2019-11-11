using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using WindowsDisplayAPI;

namespace DisplaySettingCCDSave.Classes
{
    internal class SafekeepingManager
    {
        private static object syncObj = new object();
        private string file_name = "displayseting.json";

        private List<Tuple<string, List<Display>>> settings;
        public List<Tuple<string, List<Display>>> Settings { 
            get {return settings; } 
            set { 
                if (value != null)
                    settings = value;
            } 
        }
        public SafekeepingManager()
        {
            settings = new List<Tuple<string, List<Display>>>();
            this.Load();
        }
        ~SafekeepingManager()
        {
            this.Save();
        }
        public bool Save()
        {
            try
            {
                var jsonsettingsList = Serialization.ObjectToString(settings);//JsonConvert.SerializeObject(settings);
                lock (syncObj)
                {
                    using (StreamWriter sw = new StreamWriter(this.getFileLocation(), false, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(jsonsettingsList);
                    }
                }
                return true;
            }catch(Exception ex)
            {
                Logging.Log("Error save display setting", ex);
                return false;
            }

        }
        public bool Load()
        {
            try
            {
                string jsonsettingsList;
                lock (syncObj)
                {
                    using (StreamReader sw = new StreamReader(this.getFileLocation(), System.Text.Encoding.UTF8))
                    {
                        jsonsettingsList = sw.ReadToEnd();
                    }
                }
                settings = Serialization.StringToObject(jsonsettingsList, settings.GetType()) as List<Tuple<string, List<Display>>>;//JsonConvert.DeserializeObject<List<Tuple<string, List<Display>>>>(jsonsettingsList);
                return true;
            }
            catch (Exception ex)
            {
                Logging.Log("Error load display setting", ex);
                settings = new List<Tuple<string, List<Display>>>();
                return false;
            }
        }
        public string getFileLocation()
        {
            try
            {
                string patch = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                patch += "\\" + file_name;
                return patch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "c:\\temp\\" + file_name;
            }
        }
    }
}
