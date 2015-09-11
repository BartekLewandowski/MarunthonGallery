using System;
using System.IO;
using System.Collections;
using System.Windows;
using System.Windows.Forms;


/// <summary>
/// Summary description for IniFiles.
/// </summary>
namespace PulsarSystem
{
    public interface IIniFiles
    {
        string GetValue(string KeyName);
        void SetValue(string KeyName, string Value);
        void RemoveKey(string KeyName);
    }

    public class IniFiles : IIniFiles
    {
        ArrayList iniFileContent = new ArrayList();

        string iniFile;
        string MainDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\";
        public IniFiles(string iniFileName, bool create = false)
        {
            MainDir = MainDir.Replace(@"file:\", "");
            iniFile = MainDir + iniFileName;
            if (!File.Exists(iniFile))
            {
                if (create)
                {
                    FileStream fs = File.Create(iniFile);
                    fs.Close();
                }
                else
                    throw new Exception(String.Format("Brak pliku {0}", iniFile));
            }
        }

        private void LoadIniContent()
        {
            StreamReader sr = new StreamReader(iniFile);
            string s = "";
            iniFileContent.Clear();
            while ((s = sr.ReadLine()) != null)
            {
                iniFileContent.Add(s);
            };
            sr.Close();
        }

        private void SaveIniContent()
        {
            if (File.Exists(iniFile)) File.Delete(iniFile);
            StreamWriter sw = new StreamWriter(iniFile);

            for (int a = 0; a < iniFileContent.Count; a++)
            {
                sw.WriteLine(iniFileContent[a]);
            }
            sw.Flush();
            sw.Close();
        }

        public string GetValue(string KeyName)
        {
            string res = null;
            this.LoadIniContent();
            for (int a = 0; a < iniFileContent.Count; a++)
            {
                string[] tmp = iniFileContent[a].ToString().Split(Convert.ToChar("="));
                tmp[0] = tmp[0].Trim();
                if (tmp[0].Trim() == KeyName.Trim())
                {
                    if (tmp.Length > 1)
                    {
                        res = "";
                        for (int b = 1; b < tmp.Length - 1; b++)
                        {
                            res += tmp[b].Trim() + "=";
                        }
                        res += tmp[tmp.Length - 1].Trim();
                    }
                }
            }
            return res;
        }

        public void RemoveKey(string KeyName)
        {
            int idx = -1;
            this.LoadIniContent();
            for (int a = 0; a < iniFileContent.Count; a++)
            {
                string[] tmp = iniFileContent[a].ToString().Split(Convert.ToChar("="));
                tmp[0] = tmp[0].Trim();
                if (tmp[0].Trim() == KeyName.Trim())
                {
                    idx = a;
                }
            }
            if (idx > -1) iniFileContent.RemoveAt(idx);
            this.SaveIniContent();
        }


        public void SetValue(string KeyName, string Value)
        {
            if (this.GetValue(KeyName) == null)
            {
                iniFileContent.Add(KeyName + "=" + Value);
                this.SaveIniContent();
            }
            else
            {
                this.RemoveKey(KeyName);
                this.SetValue(KeyName, Value);
            }
        }
    }
}