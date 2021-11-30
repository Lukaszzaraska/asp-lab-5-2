using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Models
{
   public  interface ICrudProductRepository
    {
        Contact Find(int id);
        Contact Delete(int id);
        Contact Add(Contact contact);
        Contact Update(Contact contact);
        Contact FindById(int id);
        IList<Contact> FindAll();
    }
}
