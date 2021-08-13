using System.Configuration;
using System.Reflection;

namespace PMWORK.Admin
{
    public static class EnCoding
    {
        public static void Encryption()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
                connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            config.Save();
        }

        public static void Decryption()
        {
            var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringSection != null && connectionStringSection.SectionInformation.IsProtected)
                connectionStringSection.SectionInformation.UnprotectSection();
            config.Save();
        }

    }
}