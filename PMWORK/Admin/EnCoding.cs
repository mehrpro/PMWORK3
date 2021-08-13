using System.Configuration;
using System.Reflection;

namespace PMWORK.Admin
{
    public static class EnCoding
    {
        public static void Encryption(string key)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
            {
                connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            config.Save();

        }

        public static void Decryption(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringSection != null && connectionStringSection.SectionInformation.IsProtected)
            {
                connectionStringSection.SectionInformation.UnprotectSection();
            }
            config.Save();
        }

    }
}