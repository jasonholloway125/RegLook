using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeStewthEmailParser
{
    internal class DataManager
    {
        private readonly string configFilePath;

        public DataManager(string fileName)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pluginFolder = Path.Combine(appData, "Seamless Intelligence", "Email Parser");

            Directory.CreateDirectory(pluginFolder);

            configFilePath = Path.Combine(pluginFolder, fileName);
        }

        public void CacheConfig<T>(T config)
        {
            try
            {
                string json = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(configFilePath, json);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to save data: {e.Message}", e);
            }
        }

        public T LoadCachedConfig<T>()
        {
            try
            {
                string json = File.ReadAllText(configFilePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
                return default(T);
            }
        }

        public void ExportConfig<T>(T config, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to save data: {e.Message}", e);
            }
        }

        public T ImportConfig<T>(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Failed to load data: {e.Message}");
                return default(T);
            }
        }
    }
}
