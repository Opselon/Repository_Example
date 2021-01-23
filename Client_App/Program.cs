using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repositories;
using DataLayer.Services;

namespace Client_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyContext db=new MyContext();

            //Person p=new Person()
            //{
            //   Name = "Iman",
            //    Family = "Madaeny",
            //    WebSite = "TopLearn.Com"
            //};
            //db.Persons.Add(p);
            //db.SaveChanges();

            MyContext db = new MyContext();
            IPersonRepository personRepository=new PersonRepository(db);
            personRepository.InsertPerson(new Person()
            {
                Name = "Ali",
                Family = "AliZadeh",
                WebSite = "Barnamenevisan.org"
            });
            personRepository.Save();


            db.Dispose();
        }
    }
}
