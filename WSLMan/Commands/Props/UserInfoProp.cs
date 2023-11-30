using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSLMan.Commands.Props
{
    public class UserInfoProp
    {
        public string username =        "";
        public string password =        "";
        public string uid =             "";
        public string gid =             "";
        public string userDescription = "";
        public string homeDirectory =   "";
        public string shell =           "";

        private bool _isUser =          false;
        public UserInfoProp(string username, string password, string uid, string gid, string userDescription, string homeDirectory, string shell)
        {
            this.username =         username;
            this.password =         password;
            this.uid =              uid;
            this.gid =              gid;
            this.userDescription =  userDescription;
            this.homeDirectory =    homeDirectory;
            this.shell =            shell;

            if(shell.ToLower().IndexOf("nologin") != -1)
                _isUser = false;
            else 
                _isUser = true;
        }

        public bool IsUser()
        { 
            return _isUser;
        }

        public override string ToString()
        {
            return $"username: {username}, password: {password}, uid: {uid}, gid: {gid}, description: {userDescription}, home directory: {homeDirectory}, shell: {shell}, isUser: {_isUser}";
        }
    }
}
