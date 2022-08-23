using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public class CredentialsRepo: ICredentialsRepo
    {
        private Dictionary<string, string> ValidUsersDictionary = new Dictionary<string, string>()
        {
               {"satyam","satyam"},
               {"shivam","shivam"}
        };
        public Dictionary<string,string> GetCredentials()
        {
            return ValidUsersDictionary;
        }
    }
}
