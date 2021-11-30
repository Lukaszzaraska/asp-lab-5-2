using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Models
{
    public class CrudProductRepository : ICrudProductRepository
    {
        private ApplicationDbContext _context;
        public CrudProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Contact Find(int id)
        {
            return _context.Contacts.Find(id);
        }
        public Contact Delete(int id)
        {
            var product = _context.Contacts.Remove(Find(id)).Entity;
            _context.SaveChanges();
            return product;
        }
        public Contact Add(Contact product)
        {
            var entity = _context.Contacts.Add(product).Entity;
            _context.SaveChanges();
            return entity;
        }
        public Contact Update(Contact contact)
        {
            Contact original = _context.Contacts.Find(contact.Id);
            original.Email = contact.Email;
            original.Phone = contact.Phone;
            EntityEntry<Contact> entityEntry = _context.Contacts.Update(original);
            _context.SaveChanges();
            return entityEntry.Entity;
        }
        public Contact FindById(int id)
        {
            return _context.Contacts.Find(id);
        }
        public IList<Contact> FindAll()
        {
            return _context.Contacts.ToList();
        }
    }
}
