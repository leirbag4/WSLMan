using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using WSLMan.Distro;

namespace WSLMan.Save
{
    //
    // This class will create a 'dconfig.cfg' file for configuration and extra info that will be stored
    // at the same path level of the distro. If distro is deleted, this file would be deleted
    //
    public class DistroConfig
    {
        public const string Filename = "dconfig.cfg";

        public string Description { get; set; }     // A user custom description 
        public DateTime LastTimeOpen { get; set; }  // The last time this app opened the current distro

        private bool _modified = false;             // If app modifies this file, then it is saved at Closing App State

        public void Reset()
        {
            Description =   "";
            LastTimeOpen =  DateTime.MinValue.ToUniversalTime(); // if distro was never opened with this app, then hold the most minimum value for date
        }

        // When any property is changed, this method should be called
        public void SetAsModified()
        {
            _modified = true;
        }

        // If this file is saved, just cancel the '_modified' flag
        public void SetAsSaved()
        { 
            _modified = false;
        }

        // This can be checked before app closes so you can Save the file if needed
        public bool SaveNeeded()
        {
            return _modified;
        }

        // Call this when distro is launched by this app. It can be used to sort the most
        // recent used distros on a list and show them to the user at the top or begining of any menu
        public void OpenedNow()
        {
            LastTimeOpen = DateTime.UtcNow;
            SetAsModified();
        }

    }
}
