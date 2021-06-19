using System;
using System.Collections.Generic;
using Lab4.Interfaces;

namespace Lab4.Models
{
    public class Phone : IDevice
    {
        public Brands Brand { get; set; }
        public string Model { get; set; }
        public OS OperatingSystem { get; set; }
        private List<Application> _installedApplications;

        public Phone()
        {
            _installedApplications = new List<Application>();
        }

        public bool InstallBrandApplication(BrandApplication brandApplication)
        {
            if (Brand == brandApplication.SupportedBrand)
            {
                _installedApplications.Add(brandApplication);
                return true;
            }

            return false;
        }

        public bool InstallApplication(Application application)
        {
            _installedApplications.Add(application);
            return true;
        }

        public bool ContainsApp(Application application)
        {
            return _installedApplications.Contains(application);
        }
    }
}