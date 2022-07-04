using PhonbookDatalayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonbookDatalayer.Services
{
    public class PhoneBookRepository : IphoneBookRepository
    {
        PhoneBookEntities1 db = new PhoneBookEntities1();

        public PhoneBookRepository(PhoneBookEntities1 context)
        {
           db = context;
        }

        public bool DeleteUsers(Users users)
        {
            try
            {
                db.Entry(users).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteUsers(int userId)
        {
            try
            {
                var user = GetUsersById(userId);
                DeleteUsers(user);
                return true;    
            }
            catch
            {

                return false;
            }
        }

        public List <Users> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public IEnumerable<Users> GetAllUsersByFilter(string parameter)
        {
            return db.Users.Where(c=>c.FirstName.Contains(parameter)||c.LastName.Contains(parameter)||c.Email.Contains(parameter)).ToList();
        }

        public Users GetUsersById(int UserId)
        {
            return db.Users.Find(UserId);
        }

        public bool InsertUsers(Users user)
        {
            try
            {
                db.Users.Add(user);
                return true;
            }
            catch
            {

               return false;
            }
        }
        public bool UpdateUsers(Users user)
        {
            try
            {
                db.Entry(user).State =EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }

      
    }
}
