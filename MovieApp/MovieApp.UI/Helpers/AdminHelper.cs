using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Service.Models;

namespace MovieApp.UI.Helpers
{
    public class AdminHelper
    {
        MovieAppContext _context;
        public AdminHelper()
        {
            _context = new MovieAppContext();
        }


        public bool IsLoginSuccess(Admin adminModel)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            var admin = _context.Admins.Where(x => x.AdminName == adminModel.AdminName).FirstOrDefault();

            if (admin!=null)
            {
                if (admin.AdminPassword ==crypto.Compute(adminModel.AdminPassword,admin.Salt))
                {
                    return true;
                }
                

            }
            return false;

        }


        }


    }

