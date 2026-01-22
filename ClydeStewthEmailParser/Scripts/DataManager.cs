using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClydeStewthEmailParser
{
    internal class DataManager
    {
        private readonly string configFilePath;

        public DataManager()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string pluginFolder = Path.Combine(appData, "Seamless Intelligence", "Email Parser");

            Directory.CreateDirectory(pluginFolder);

            configFilePath = Path.Combine(pluginFolder, "config.json");
        }

        public void CacheConfig(Config config)
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

        public Config LoadCachedConfig()
        {
            try
            {
                if (!File.Exists(configFilePath))
                    return new Config();

                string json = File.ReadAllText(configFilePath);
                return JsonConvert.DeserializeObject<Config>(json) ?? new Config();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to load data: {e.Message}", e);
            }
        }

        public void ExportConfig(Config config, string filePath)
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

        public Config ImportConfig(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Config>(json) ?? throw new Exception("Returned NULL");
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to load data: {e.Message}", e);
            }
        }
    }
}
