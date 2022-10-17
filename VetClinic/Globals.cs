using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using VetDbContext;

namespace VetClinic
{
    internal class Globals
    {
       // public static PetClinicdbConnection dbContext;
        private static PetClinicdbConnection _dbContextInternal;
        public static PetClinicdbConnection dbContext
        {
            get
            {
            if(_dbContextInternal == null)
                {
                    _dbContextInternal = new PetClinicdbConnection(); // Exceptions
                }
                    
                    return _dbContextInternal;
            }
        }

       public static Register registerWindow = new Register();
       public static MainWindow mainWindow = new MainWindow();
       public static Login loginWindow = new Login();


    }
}
