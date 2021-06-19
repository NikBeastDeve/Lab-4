using System;
namespace Lab4.Models
{
    public class BrandApplication : Application
    {
        public Brands SupportedBrand;
        public BrandApplication(OS OS,
            bool Paid,
            string Name,
            double Price,
            double Version,
            string Author,
            Brands Brand) : base(OS, Paid, Name, Price, Version, Author)
        {
            this.SupportedBrand = Brand;
        }


    }
}
