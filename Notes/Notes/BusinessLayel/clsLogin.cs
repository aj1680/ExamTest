using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Notes.BusinessLayel;
using Notes.DataLayer;

namespace Notes.BusinessLayel
{
    public class clsLogin
    {
        MessagingDAL DA = new MessagingDAL();
        public bool Login(clsUser user)
        {
            bool status = false;
            DA.UserLogin(user);
            return status;
        }

    }
}