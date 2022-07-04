using PhonbookDatalayer.Repository;
using PhonbookDatalayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonbookDatalayer.Context
{
    public class unitOfWork : IDisposable
    {
        PhoneBookEntities1 db = new PhoneBookEntities1();

        private IphoneBookRepository _PhoneBookRepository;

        public IphoneBookRepository PhoneBookRepository
        {
            get
            {
                if (_PhoneBookRepository == null)
                {
                    _PhoneBookRepository = new PhoneBookRepository(db);
                }

                return _PhoneBookRepository;

            } }
        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
