using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using NotebookAPI.Models;
using DbUpdateConcurrencyException = Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException;

namespace NotebookAPI.Controllers
{
    public class ContactController : ApiController
    {
        private PersonContext db = new PersonContext();

        // GET: api/Contacts
        public IQueryable<Contact> GetContacts()
        {
            return db.Contact.Include("ContactType");
        }

        // GET: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult GetContact(int id)
        {
            IQueryable<Contact> q = db.Contact.Include("ContactType").Where(item => item.Id == id);
            if (q.Count() == 0)
            {
                return NotFound();
            }

            Contact contact = q.First();
            return Ok(contact);
        }

        // PUT: api/Contacts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContact(int id, Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contact.Id)
            {
                return BadRequest();
            }

            db.Entry(contact).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Contacts
        [ResponseType(typeof(Contact))]
        public IHttpActionResult PostContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contact.Add(contact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contact.Id }, contact);
        }

        // DELETE: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult DeleteContact(int id)
        {
            Contact contact = db.Contact.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            db.Contact.Remove(contact);
            db.SaveChanges();

            return Ok(contact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactExists(int id)
        {
            return db.Contact.Count(e => e.Id == id) > 0;
        }
    }
}
