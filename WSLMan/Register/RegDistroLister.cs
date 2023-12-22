using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;


namespace WSLMan.Register
{
    public class RegDistroLister
    {
        private static bool _error = false;

        private static List<RegDistroInfo> _distros;
        public static RegDistroInfo[] GetAll()
        {
            _error = false;
            _distros = new List<RegDistroInfo>();

            try
            {
                string registryPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Lxss";

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {
                    if (key != null)
                    {
                        string[] subKeyNames = key.GetSubKeyNames();

                        foreach (string subKeyName in subKeyNames)
                        {
                            using (RegistryKey subKey = key.OpenSubKey(subKeyName))
                            {
                                if (subKey != null)
                                {
                                    object basePathValue =          subKey.GetValue("BasePath");
                                    object defaultUidValue =        subKey.GetValue("DefaultUid");
                                    object distributionNameValue =  subKey.GetValue("DistributionName");
                                    object stateValue =             subKey.GetValue("State");
                                    object versionValue =           subKey.GetValue("Version");
                                    object packageFamilyValue =     subKey.GetValue("PackageFamilyName");

                                    if (basePathValue != null && defaultUidValue != null &&
                                        distributionNameValue != null && stateValue != null && versionValue != null)
                                    {
                                        string hash =               subKeyName;
                                        string basePath =           basePathValue.ToString();
                                        string defaultUid =         defaultUidValue.ToString();
                                        string distributionName =   distributionNameValue.ToString();
                                        string state =              stateValue.ToString();
                                        string version =            versionValue.ToString();
                                        string packageFamily =      packageFamilyValue != null ? packageFamilyValue.ToString() : "";


                                        InsertDistro(hash, basePath, defaultUid, distributionName, state, version, packageFamily);
                                    }
                                    else
                                    {
                                        Warning($"Can't find distro info for '{subKeyName}' at registry on '" + registryPath + "'");
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        CallError("Can't find hashed keys for distros.");
                    }
                }
            }
            catch (Exception ex)
            {
                CallError($"Error while reading registry: {ex.Message}");
            }

            return _distros.ToArray();
        }
        private static void InsertDistro(string hash, string basePath, string defaultUid, string distributionName, string state, string version, string packageFamily)
        {
            try
            {
                RegDistroInfo distro = new RegDistroInfo(hash, basePath, defaultUid, distributionName, state, version, packageFamily);
                _distros.Add(distro);
            }
            catch (Exception e)
            {
                CallError("Can't parse distro from registry. Hash: " + hash);
            }
        }

        private static void Warning(string str)
        {
            _error = true;
            XConsole.Warning(str);
        }

        private static void CallError(string str)
        {
            _error = true;
            PrintError(str);
        }

        private static void Println(string str)
        {
            XConsole.Println(str);
        }

        private static void PrintError(string str)
        {
            XConsole.PrintError(str);
        }


    }
}
