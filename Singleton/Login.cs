using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Login
    {
        public void logInUserNamePassword(string userName, string password)
        {

            //checking password and email.....

            //if true..

            //if false..

            Logger.Instance.RecordLogIn(userName);

        }

        public void logInSms(string phone)
        {

            //sending sms

            //checking otp

            //if true..

            //if false..



            Logger.Instance.RecordLogIn(phone);
        }
    }
}
