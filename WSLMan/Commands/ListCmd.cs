using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSLMan.Commands.Result;
using WSLMan.Distro;
using WSLMan.Register;

namespace WSLMan.Commands
{
    public class ListCmd : BaseCmd
    {
        private List<DistroInfo> _distros;
        private bool _cmd_list_allowed = false;
        private bool _matchWithRegister = true;

        /// <summary>
        /// Get the list of all the installed distros
        /// </summary>
        /// <param name="matchWithRegister">merge and match info with windows registry to find for example installed path of distros but at the cost of speed. Set to 'false' to refresh only state.</param>
        /// <returns></returns>
        public async Task<ListCmdResult> ListDistrosAsync(bool matchWithRegister = true)
        {
            _distros =              new List<DistroInfo>();
            _cmd_list_allowed =     false;
            _matchWithRegister =    matchWithRegister;

            return await CreateCommand<ListCmdResult>("-l -v");
        }


        protected override void OnDataReceived(string data)
        {
            string[] parts = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 3)
            {
                if ((parts[0].ToLower() == "name") && (parts[1].ToLower() == "state") && (parts[2].ToLower() == "version"))
                {
                    //Println("[cmd list allowed]");
                    _cmd_list_allowed = true;
                }
                else if (_cmd_list_allowed)
                {

                    if ((parts.Length >= 4) && (parts[0] == "*"))
                    {
                        try
                        {
                            DistroInfo dinfo = new DistroInfo(parts[1], parts[2], parts[3], true);
                            _distros.Add(dinfo);
                        }
                        catch (Exception e)
                        {
                            CallError("Can't parse all the distros. Line (default) -> " + parts);
                        }
                    }
                    else if (parts.Length >= 3)
                    {
                        try
                        {
                            DistroInfo dinfo = new DistroInfo(parts[0], parts[1], parts[2], false);
                            _distros.Add(dinfo);
                        }
                        catch (Exception e)
                        {
                            CallError("Can't parse all the distros. Line -> " + parts, e);
                        }
                    }


                }
            }
        }

        protected override void OnErrorDataReceived(string data)
        {

        }


        protected override void OnComplete(BaseResult result)
        {
            ListCmdResult listResult = (ListCmdResult)result;

            if (_matchWithRegister)
            {
                // find distros on windows registry first
                List<RegDistroInfo> regDistros = RegDistroLister.GetAll().ToList();

                // now compare them with the returned by 'wsl --list -v' and do a mix
                foreach (var distro in _distros)
                {
                    foreach (var regDistro in regDistros)
                    {
                        // found one coincidence between a registry distro and the wls command 'list'
                        if (distro.Name == regDistro.DistributionName)
                        {
                            distro.SetRegDistroInfo(regDistro);
                            distro.LoadConfig();
                            regDistros.Remove(regDistro);       // remove the selected registry distro
                            break;                              // and break the loop to speed up
                        }
                    }
                }

                // if not 0, then registry distros do not match with wls command 'list'
                if (regDistros.Count > 0)
                    CallError("There was an error while merging registry distros with 'wsl --list -v' command.");
            }

            listResult.distros = _distros;
        }


    }
}
