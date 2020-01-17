using System;
namespace SunsetSunrise
{
   class SunMode
    {
        public string Status { get; set; } // omadus, peab oelma sama nimega mis seal url-s ja suure S sest getter ja setter on vajalikud
        public Results Results { get; set; } //omadus, seal sees on teised omaduses
    }

    public class Results
    {
        public string Sunrise { get; set; } //omadus, ta on Resultsi sees
        public string Sunset { get; set; }//omadus
    }
}
