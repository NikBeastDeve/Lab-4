using System;
using Lab4.Interfaces;

namespace Lab4.Models
{
    public class Human
    {
        public double Cash { get; set; }
        public Phone Phone { get; set; }

        public bool InstallApplication(Application application)
        {
            if (CanAfford(application) && IsAppInstalled(application) && IsAppSupportedOS(application))
            {
                return Phone.InstallApplication(application);
            }

            return false;
        }

        public bool CanAfford(Application application)
        {
            if (application.Price > this.Cash)
            {
                return false;
            }
            return true;
        }

        public bool IsAppInstalled(Application application)
        {
            return Phone.ContainsApp(application);
        }

        public bool IsAppSupportedOS(Application application)
        {
            if (application.SupportedOS == Phone.OperatingSystem)
            {
                return true;
            }
            return false;
        }
    }
}