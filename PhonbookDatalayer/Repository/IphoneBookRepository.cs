using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonbookDatalayer.Repository
{
    public  interface IphoneBookRepository
    {
        List<Users> GetAllUsers();
        IEnumerable<Users> GetAllUsersByFilter(string parameter);
        bool InsertUsers(Users user);
        Users GetUsersById(int UserId);
        bool UpdateUsers(Users user);
        bool DeleteUsers(Users users);
        bool DeleteUsers(int UserId);
      
    }
}
