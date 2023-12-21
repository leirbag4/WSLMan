using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan
{
    public class Defines
    {
        public static string InstallMsg = "--------------------------------------------------------------------------------------\n" +
                 "\n" +
                 "Go to https://learn.microsoft.com/en-us/windows/wsl/install or" +
                 "\n\n" +
                 "--------------------------------------------------------------------------------------\n" +
                 "Option A (recommended):\n" +
                 "\n" +
                 "  Open PowerShell or Windows Command Prompt in administrator mode by right-clicking and selecting \"Run as administrator\", enter the wsl --install command, then restart your machine.\n" +
                 "\n" +
                 "  [ wsl --install ]\n" +
                 "\n" +
                 "--------------------------------------------------------------------------------------\n" +
                 "Option B (manual):\n" +
                 "\n" +
                 "  If you're running an older build, or just prefer not to use the install command\n" +
                 "\n" +
                 "     1. Enable the Windows Subsystem for Linux\n" +
                 "\n" +
                 "     Open PowerShell as Administrator ant type:\n" +
                 "\n" +
                 "        [ dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart ]\n" +
                 "\n" +
                 "     2. Check requirements for running WSL 2\n" +
                 "\n" +
                 "     To update to WSL 2, you must be running Windows 10\n" +
                 "        For x64 systems: Version 1903 or later, with Build 18362.1049 or later.\r" +
                 "        For ARM64 systems: Version 2004 or later, with Build 19041 or later.\n" +
                 "        or Windows 11\n" +
                 "\n" +
                 "     3. Enable Virtual Machine feature\n" +
                 "\n" +
                 "        Before installing WSL 2, you must enable the Virtual Machine Platform optional feature. Your machine will require virtualization capabilities to use this feature.\n" +
                 "        Open PowerShell as Administrator and run:\n" +
                 "\n" +
                 "        [ dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart ]\n" +
                 "\n      Restart your machine to complete the WSL install and update to WSL 2.\n" +
                 "\n" +
                 "     4. Download the Linux kernel update package\n" +
                 "\n" +
                 "        The Linux kernel update package installs the most recent version of the WSL 2 Linux kernel for running WSL inside the Windows operating system image. (To run WSL from the Microsoft Store, with more frequently pushed updates, use wsl.exe --install or wsl.exe --update.).\n" +
                 "\n" +
                 "        Download the latest package and install it:\n" +
                 "        https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi\n" +
                 "\n" +
                 "     5. Set WSL 2 as your default version\n" +
                 "\n" +
                 "        Open PowerShell and run this command to set WSL 2 as the default version when installing a new Linux distribution:\n" +
                 "\n" +
                 "        [ wsl --set-default-version 2 ]" +
                 "\n";
    }
}
