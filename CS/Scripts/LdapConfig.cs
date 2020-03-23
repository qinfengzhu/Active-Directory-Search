using System;

namespace ADSearch.Scripts
{
    public class LdapConfig
    {
        public static readonly LdapConfig Instance = new LdapConfig();
        public string LdapId { get; set; }
        public string LdapAdministrator { get; set; }
        public string LdapAdministratorPassword { get; set; }
        static LdapConfig()
        {
            Instance.LdapId = System.Configuration.ConfigurationManager.AppSettings["LdapId"];
            Instance.LdapAdministrator = System.Configuration.ConfigurationManager.AppSettings["LdapAdministrator"];
            Instance.LdapAdministratorPassword = System.Configuration.ConfigurationManager.AppSettings["LdapAdministratorPassword"];
        }
    }
}
