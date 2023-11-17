using CommandLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan
{
    public class WSL
    {
        public List<DistroInfo> Distros;
        public bool Error { get; private set; } = false;

        private CmdRun proc;

        private bool _cmd_list_allowed = false;

        public WSL() 
        {
            Distros = new List<DistroInfo>();
        }

        public async Task<List<DistroInfo>> ListDistrosAsync()
        {
            TaskCompletionSource<List<DistroInfo>> tcs = new TaskCompletionSource<List<DistroInfo>>();

            Distros = new List<DistroInfo>();

            _cmd_list_allowed =         false;

            proc =                      new CmdRun(CmdType.WSL, "wsl", "-l -v");
            proc.DataReceived +=        OnListDataReceived;
            proc.ErrorDataReceived +=   OnListDataErrorReceived;
            //proc.Complete +=            OnComplete;
            //proc.Start();

            proc.Complete += () => OnComplete(tcs);

            await Task.Run(() => proc.Start());

            return await tcs.Task;

        }



        private void OnListDataReceived(string data)
        {
            string[] parts = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 3)
            {
                if ((parts[0].ToLower() == "name") && (parts[1].ToLower() == "state") && (parts[2].ToLower() == "version"))
                {
                    //Println("[cmd list allowed]");
                    _cmd_list_allowed = true;
                }
                else if(_cmd_list_allowed)
                {

                    if ((parts.Length >= 4) && (parts[0] == "*"))
                    {
                        try
                        {
                            DistroInfo dinfo = new DistroInfo(parts[1], parts[2], parts[3], true);
                            Distros.Add(dinfo);
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
                            Distros.Add(dinfo);
                        }
                        catch (Exception e)
                        {
                            CallError("Can't parse all the distros. Line -> " + parts);
                        }
                    }


                    //Println("\n---");
                }
            }


            //Println("=" + data + " length: " + parts.Length);
        }

        private void OnListDataErrorReceived(string data)
        {
            CallError("ERROR:" + data);
        }

        /*private void OnComplete()
        {
            Println("[ENDS]");
        }*/
        private void OnComplete(TaskCompletionSource<List<DistroInfo>> tcs)
        {
            //Println("[ENDS]");
            tcs.SetResult(Distros);
        }

        private void CallError(string str)
        {
            XConsole.PrintError(str);
            Error = true;
        }


        private void Print(string str)
        {
            XConsole.Print(str);
        }

        private void Println(string str)
        { 
            XConsole.Println(str);
        }
    }
}
