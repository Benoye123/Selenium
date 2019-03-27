using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
   public class Constants
    {
        int? i = null;
        string u = null;
        bool? v = null;
        


       public enum Username
        {
            correctCredentials,
            wrongUserName,
            wrongPasword
        };

        public static void swtcEx(Username user)
        {
           
            switch (user)
            {
                case Username.correctCredentials:
                   
                    break;
                case Username.wrongUserName:
                    break;
                case Username.wrongPasword:
                    break;
                default:
                    break;
            }

           
        }
    }
}
