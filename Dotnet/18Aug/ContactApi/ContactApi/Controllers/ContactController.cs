using ContactAPI.DATA;
using ContactAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ContactController : Controller
    {
        private readonly DBContext dbContext;
        public ContactController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {


          return  Ok(await dbContext.Contacts.ToListAsync());
           
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {
            var contact =  await dbContext.Contacts.FindAsync(id);
            if (contact == null)

            {
                return NotFound();
            }
            return Ok(contact);
        }


        [HttpPost]
        
        public async Task<IActionResult>AddContacts(AddContactRequest addContactRequest)
        {
            var contact = new Contact
            {
                Id = Guid.NewGuid(),
                Address = addContactRequest.Address,
                Email = addContactRequest.Email,
                FullName = addContactRequest.FullName,
                Phone = addContactRequest.Phone
            };
          await  dbContext.Contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();
            return Ok(contact);

        }
        [HttpPost]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id,UpdateRequestContacts updateRequestContacts)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact != null) 
            {
                contact.FullName = updateRequestContacts.FullName;
                contact.Address= updateRequestContacts.Address;
                contact.Phone= updateRequestContacts.Phone;
                contact.Email= updateRequestContacts.Email;

                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact != null)
            { 
            dbContext.Remove(contact);
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            
            }
            return NotFound(id);
        }


    }
}
