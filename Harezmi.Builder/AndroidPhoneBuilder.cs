using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Builder
{
    public class AndroidPhoneBuilder: IPhoneBuilder
    {
        private MobilePhone _phone;

        public AndroidPhoneBuilder()
        {
            _phone = new MobilePhone("Android Phone");
        }

        #region IPhoneBuilder Members

        public void BuildScreen()
        {
            _phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;
        }

        public void BuildBattery()
        {
            _phone.PhoneBattery = Battery.MAH_1500;
        }

        public void BuildOS()
        {
            _phone.PhoneOS = OperatingSystem.ANDROID;
        }

        public void BuildStylus()
        {
            _phone.PhoneStylus = Stylus.YES;
        }

        // GetResult Method which will return the actual phone
        public MobilePhone Phone
        {
            get { return _phone; }
        }

        #endregion
    }
}
