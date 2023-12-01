using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInlämning
{
    internal class UserManager
    {
            private readonly IDatabase db;

            public UserManager(IDatabase datab)
            {
                db = datab ?? throw new ArgumentNullException(nameof(datab));
            }

            public void AddUser(User user)
            {
                db.AddUser(user);
            }

            public void RemoveUser(int userId)
            {
                db.RemoveUser(userId);
            }

            public User GetUser(int userId)
            {
                return db.GetUser(userId);
            }

    }
}
