using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WSLMan
{
    public class SaveData
    {
        // A save data file version for possible future incompatible properties
        public static string Version { get { return saveData.version; } set { saveData.version = value; } }

        // A folder path for downloaded 'tar.gz' ditros
        public static string CustomPackageDirPath { get { return saveData.custom_package_dir_path; } set { saveData.custom_package_dir_path = value; } }
        
        // A folder path for the creation of the virtual hard drive 'vhdx' file
        public static string OutputVhdxDirPath { get { return saveData.output_vhdx_dir_path; } set { saveData.output_vhdx_dir_path = value; } }

        // A folder path for the creation of the virtual hard drive 'vhdx' file at the browse single package menu
        public static string OutputCloneVhdxDirPath { get { return saveData.output_clone_vhdx_dir_path; } set { saveData.output_clone_vhdx_dir_path = value; } }

        // A folder path for the creation of the virtual hard drive 'vhdx' file at the browse single package menu
        public static string OutputBrowseSingleVhdxDirPath { get { return saveData.output_browse_single_vhdx_dir_path; } set { saveData.output_browse_single_vhdx_dir_path = value; } }

        // The last 'tar.gz' file path used when browsing on a new creation
        public static string LastPackageFilePath { get { return saveData.last_package_file_path; } set { saveData.last_package_file_path = value; } }

        

        private static SaveData saveData = null;
        private const string FILENAME = "config.cfg";

        public string version { get; set; } = "";
        public string output_vhdx_dir_path { get; set; } = "";
        public string output_clone_vhdx_dir_path { get; set; } = "";
        public string output_browse_single_vhdx_dir_path { get; set; } = "";
        public string custom_package_dir_path { get; set; } = "";
        public string last_package_file_path { get; set; } = "";


        public static void Initialize()
        {
            bool createNew = false;

            try
            {
                Load();
            }
            catch(Exception e) 
            {
                createNew= true;
            }

            if (createNew)
            {
                try
                {
                    CreateNew();
                    Save();
                }
                catch (Exception e)
                {
                    XConsole.Alert("Can't create and write the 'save data'!");
                }
            }
        }

        private static void CreateNew()
        {
            saveData = new SaveData();
            saveData.version = "0.6.0";
            saveData.output_vhdx_dir_path =                 "";
            saveData.output_clone_vhdx_dir_path =           "";
            saveData.output_browse_single_vhdx_dir_path =   "";
            saveData.custom_package_dir_path =              "";
            saveData.last_package_file_path =               "";
        }

        public static void Load()
        {
            string json =   File.ReadAllText(FILENAME);
            saveData =      JsonSerializer.Deserialize<SaveData>(json);
        }
        public static void Save()
        {
            string json = JsonSerializer.Serialize(saveData);
            File.WriteAllText(FILENAME, json);
        }

    }
}
