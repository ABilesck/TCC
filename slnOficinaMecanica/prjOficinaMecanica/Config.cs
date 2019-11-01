using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOficinaMecanica
{
    class Config
    {
        public static void UpdateAppSettings(string chave, string valor)

        {

            // Open App.Config of executable

            System.Configuration.Configuration config = 
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);



            // Add an Application Setting.

            config.AppSettings.Settings.Remove(chave);

            config.AppSettings.Settings.Add(chave, valor);



            // Save the configuration file.

            config.Save(ConfigurationSaveMode.Modified);



            // Force a reload of a changed section.

            ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
