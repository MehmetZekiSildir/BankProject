using Bankamatik_40.ORM.Context;
using Bankamatik_40.ORM.Entities;
using Microsoft.DotNet.ProjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik_40.ORM.Operetion
{
    internal class Execute
    {

        public static int Kurumsal_Insert(Company entitiy)
        {
            using (ProjeContext db = new ProjeContext())
            {
                db.Companies.Add(entitiy);
                return db.SaveChanges();
            }
        }

        public static int Bireysel_Insert(İndivual entitiy)
        {
            using (ProjeContext db = new ProjeContext())
            {
                db.İndivuals.Add(entitiy);
                return db.SaveChanges();
            }
        }

     

    }
}
