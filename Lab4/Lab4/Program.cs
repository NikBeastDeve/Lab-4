using System;
using Lab4.Models;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args) {

            var PipingPiper = new Application(OS.Android,
                true,
                "pipingPiper",
                0.99,
                1.23,
                "Piper Who's Piping");

            var FaceBook = new Application(OS.iOS,
                false,
                "Facebook",
                0.00,
                3.23,
                "Mark");

            var VK = new Application(OS.iOS,
                false,
                "VK",
                0.00,
                5.23,
                "Some Dude");

            var SnapChat = new Application(OS.iOS,
                false,
                "snapChat",
                0.00,
                5.53,
                "Some Another Dude");

            var Mytazalyk = new Application(OS.Android,
                false,
                "mytazalyk",
                0.00,
                1.53,
                "My Friend");

            var GoogleChrome = new Application(OS.Android,
                false,
                "Google Chrome",
                0.00,
                1.53,
                "Google LTD");

            var Safari = new Application(OS.iOS,
                false,
                "Safari",
                0.00,
                5.53,
                "Apple");

            var Hogwarts = new Application(OS.iOS,
                false,
                "Hogwarts",
                0.00,
                2.3,
                "Hogwarts and Magic");

            var Moscow = new Application(OS.iOS,
                false,
                "Capital of Russia",
                0.00,
                5.53,
                "Russia");

            var socialism = new Application(OS.iOS,
                true,
                "Socialism",
                677.00,
                1991.00,
                "People");

            var phone = new Phone();
            phone.Brand = Brands.Apple;
            phone.OperatingSystem = OS.Android;
            Human jake = new Human();
            jake.Phone = phone;
            jake.Cash = 0.00;
            jake.InstallApplication(socialism);
            jake.InstallApplication(socialism);
            jake.Cash = 20.00;
            jake.InstallApplication(VK);

            var GoogleMaps = new BrandApplication(OS.Android,
                false,
                "Google Maps",
                0.00,
                5.53,
                "Google",
                Brands.Google);

            var AppleMusic = new BrandApplication(OS.iOS,
                false,
                "Apple Music",
                0.00,
                10.53,
                "Apple",
                Brands.Apple);

            jake.Phone.InstallBrandApplication(GoogleMaps);
            jake.Phone.InstallBrandApplication(AppleMusic);
        }
    }
}