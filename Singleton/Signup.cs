using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Signup
    {
        public void signUpUserNamePassword(string userName, string password)
        {

            //checking password and email.....

            //if true..

            //if false..

            Logger.Instance.RecordSignUp(userName);

        }

        public void signUpInSms(string phone)
        {

            //sending sms

            //checking otp

            //if true..

            //if false..



            Logger.Instance.RecordSignUp(phone);
        }
    }
}
