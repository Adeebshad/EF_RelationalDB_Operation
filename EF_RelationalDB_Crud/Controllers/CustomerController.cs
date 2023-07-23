using EF_RelationalDB_Crud.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_RelationalDB_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly MyWorldDbContext _myWorldDbContext;
        public CustomerController(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _myWorldDbContext.Customer
            .Include(_ => _.CustomerAddresses).ToListAsync();
            return Ok(customers);
        }
    }
}
