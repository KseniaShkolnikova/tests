﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesiki.ViewModel.Helpers
{
    internal class Ser_Desir
    {
        public static void Serialize<T>(T avtor, string file)
        {
            string desktoop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(avtor, new StringEnumConverter());
            File.WriteAllText(desktoop + "\\" + file, json);
        }

        public static T Desir<T>(string file)
        {
            string desktoop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = "";
            try
            {
                json = File.ReadAllText(desktoop + "\\" + file);
            }
            catch
            {
                File.Create(desktoop + "\\" + file).Close();
            }
            T avtor = JsonConvert.DeserializeObject<T>(json);
            return avtor;
        }
    }
}
