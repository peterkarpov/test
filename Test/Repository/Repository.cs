using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
using Test.Entities;

namespace Test
{
    public class Repository : IRepository
    {
        public Repository()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CodeFirst>());

            try
            {
                CodeFirst context = new CodeFirst();

                // Запустить инициализацию базы данных в этой точке
                context.Database.Initialize(false);
            }
            catch (Exception ex)
            {
                // Если при создании БД возникла ошибка, 
                // отобразим ее в окне отладчика
                Debug.WriteLine("Инициализация не выполнена. Ошибка: ");
                Debug.WriteLine(ex.Message);
            }
        }
        
        private CodeFirst context = new CodeFirst();



        public IEnumerable<Users> Users
        {
            get
            {
                return context.Users;
            }
        }

        public IEnumerable<City> Cities
        {
            get
            {
                return context.Cities;
            }
        }

    }
}
