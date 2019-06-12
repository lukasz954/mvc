using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.TestData
{
    public class UserData
    {
        public IEnumerable<User> Users() => new List<User>
        {
            new User{Id=1,Login="User1",Password="pass1",Name="UserName1"},
            new User{Id=2,Login="admin",Password="admin",Name="admin"},
            new User{Id=2,Login="User2",Password="pass2",Name="UserName2"}
        };
    }
}