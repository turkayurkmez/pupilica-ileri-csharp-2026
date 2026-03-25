using System;
using System.Collections.Generic;
using System.Text;

namespace usingRecordTypes
{
    internal class RegisterUserRequestClass
    {
        //Dikkat: Bu örneğin, bir android app'den gelen kullanıcı kayıt isteğidir.
        public string Email { get; init; }
        public string UserName { get; init; }

        public RegisterUserRequestClass(string email, string userName)
        {
            Email = email;
            UserName = userName;
        }

    }
}
