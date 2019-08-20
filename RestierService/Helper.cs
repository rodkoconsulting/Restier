using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

namespace RestierService
{
    public static class Helper
    {

        public static Web_ActiveUsers GetUser()
        {
            using (var context = new PolModel())
            {
                var authHeader = HttpContext.Current.Request.Headers["Authorization"];
                if (authHeader == null || !authHeader.StartsWith("Basic")) return null;
                var encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                var encoding = Encoding.GetEncoding("iso-8859-1");
                var usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));
                var separatorIndex = usernamePassword.IndexOf(':');
                var user = usernamePassword.Substring(0, separatorIndex);
                return context.ODataUsers.FirstOrDefault(u => u.UserName == user);
            }
        }

        public static bool IsManager(Web_ActiveUsers user)
        {
            return user.AccountType == "OFF";
        }
    }
}