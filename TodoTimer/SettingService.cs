using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoTimer
{
    public static class SettingService
    {
        private static readonly string Path = System.IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "setting.json"
            );
        public static Setting Load()
        {
            if (!File.Exists(Path))
                return new Setting();

            try
            {
                var json = File.ReadAllText(Path);
                return JsonSerializer.Deserialize<Setting>(json) ?? new Setting();
            }
            catch
            {
                return new Setting();
            }
        }
        public static void Save(Setting setting)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(setting, options);
            File.WriteAllText(Path, json);
        }
    }
    public class Setting
    {
        public List<string> Tags { get; set; } = new();
    }
}
