using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDisplayAPI;

namespace DisplaySettingCCDSave.Classes
{
    class SafekeepingManager
    {
        private string file_name = "displayseting.json";

        private List<Tuple<string, List<DisplaySetting>>> settings;
        public List<Tuple<string, List<DisplaySetting>>> Settings { 
            get {return settings; } 
            set { 
                if (value != null)
                    settings = value;
            } 
        }
        public SafekeepingManager()
        {
            settings = new List<Tuple<string, List<DisplaySetting>>>();
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
                var jsonsettingsList = JObject.FromObject(settings);
                using (StreamWriter sw = new StreamWriter(this.getFileLocation(), false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(jsonsettingsList);
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
                using (StreamReader sw = new StreamReader(this.getFileLocation(), System.Text.Encoding.UTF8))
                {
                    jsonsettingsList = sw.ReadToEnd();
                }
                settings = JObject.Parse(jsonsettingsList).ToObject<List<Tuple<string, List<DisplaySetting>>>>();
                return true;
            }
            catch (Exception ex)
            {
                Logging.Log("Error save display setting", ex);
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
