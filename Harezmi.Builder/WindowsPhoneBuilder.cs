using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Builder
{
    public class WindowsPhoneBuilder : IPhoneBuilder
    {
        private MobilePhone _phone;

        public WindowsPhoneBuilder()
        {
            _phone = new MobilePhone("Windows Phone");
        }

        #region IPhoneBuilder Members

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenType.ScreenType_TOUCH_CAPACITIVE;
        }

        public void BuildBattery()
        {
            _phone.PhoneBattery = Battery.MAH_2000;
        }

        public void BuildOS()
        {
            _phone.PhoneOS = OperatingSystem.WINDOWS_PHONE;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = Stylus.NO;
        }

        // GetResult Method which will return the actual phone
        public MobilePhone Phone
        {
            get { return _phone; }
        }

        #endregion
    }
}
