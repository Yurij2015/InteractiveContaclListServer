using InteractiveContaclListServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveContaclListServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        ApplicationContext db;
        public ContactsController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> Get()
        {
            return await db.Contacts.ToListAsync();
        }

        // GET api/Contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            Contact Contact = await db.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (Contact == null)
                return NotFound();
            return new ObjectResult(Contact);
        }

        // POST api/Contacts
        [HttpPost]
        public async Task<ActionResult<Contact>> Post(Contact Contact)
        {
            if (Contact == null)
            {
                return BadRequest();
            }

            db.Contacts.Add(Contact);
            await db.SaveChangesAsync();
            return Ok(Contact);
        }

        // PUT api/Contacts/
        [HttpPut]
        public async Task<ActionResult<Contact>> Put(Contact Contact)
        {
            if (Contact == null)
            {
                return BadRequest();
            }
            if (!db.Contacts.Any(x => x.Id == Contact.Id))
            {
                return NotFound();
            }

            db.Update(Contact);
            await db.SaveChangesAsync();
            return Ok(Contact);
        }

        // DELETE api/Contacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contact>> Delete(int id)
        {
            Contact Contact = db.Contacts.FirstOrDefault(x => x.Id == id);
            if (Contact == null)
            {
                return NotFound();
            }
            db.Contacts.Remove(Contact);
            await db.SaveChangesAsync();
            return Ok(Contact);
        }
    }
}
