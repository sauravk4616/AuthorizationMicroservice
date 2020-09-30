using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public class Credentials: ICredentials
    {
        private Dictionary<string,string> ValidUsersDictionary = new Dictionary<string, string>()
        {
               {"1","ARGHYADEEP SAHA"},
               {"2","BISWARUP CHAKRABORTY"},
               {"3","SAURAV KUMAR"},
               {"4","AYAN NANDI"}
        };
        public Dictionary<string,string> GetCredentials()
        {
            return ValidUsersDictionary;
        }
    }
}
