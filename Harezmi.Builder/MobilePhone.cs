using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Builder
{
    // This is the "Product" class
    public class MobilePhone
    {
        // Public properties to access phone parts

        public string PhoneName { get; private set; }
        public ScreenType PhoneScreen { get; set; }
        public Battery PhoneBattery { get; set; }
        public OperatingSystem PhoneOS { get; set; }
        public Stylus PhoneStylus { get; set; }

        public MobilePhone(string name)
        {
            PhoneName = name;
        }

        // Method to display phone details in our own representation
        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
                PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);
        }
    }

    // Some helper enums to identify various parts
    public enum ScreenType
    {
        ScreenType_TOUCH_CAPACITIVE,
        ScreenType_TOUCH_RESISTIVE,
        ScreenType_NON_TOUCH
    };

    public enum Battery
    {
        MAH_1000,
        MAH_1500,
        MAH_2000
    };

    public enum OperatingSystem
    {
        ANDROID,
        WINDOWS_MOBILE,
        WINDOWS_PHONE,
        SYMBIAN
    };

    public enum Stylus
    {
        YES,
        NO
    };
}
