using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseServer.Data;
using WarehouseServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly WarehouseDbContext _context;

        public WarehouseController(WarehouseDbContext context)
        {
            _context = context;
        }

        // GET: api/<WarehouseController>
        [HttpGet]
        public async Task<IActionResult> GetAllWarehouse()
        {
            try
            {
                // שולפים את כל הנתונים מהטבלה Warehouse
                var warehouseItems = await _context.Warehouse.ToListAsync();

                // מחזירים את הנתונים בפורמט JSON
                return Ok(warehouseItems);
            }
            catch (Exception ex)
            {
                // אם קרתה שגיאה, מחזירים שגיאה
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        //public async Task<ActionResult<IEnumerable<WarehouseItem>>> GetWarehouseItems()
        //{
        //    return await _context.Warehouse.ToListAsync();
        //}

        //[HttpGet]
        //// Define an async method that returns an ActionResult of IEnumerable of TodoItem
        //public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        //{
        //    // Return all the todo items from the database as an asynchronous operation
        //    return await _context.TodoItems.ToListAsync();
        //}




        // GET api/<WarehouseController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWarehouseById(int id)
        {
            try
            {
                // שולפים את כל הנתונים מהטבלה Warehouse
                var warehouse= await _context.Warehouse.Where(x=>x.Id==id).ToListAsync();

                // מחזירים את הנתונים בפורמט JSON
                return Ok(warehouse);
            }
            catch (Exception ex)
            {
                // אם קרתה שגיאה, מחזירים שגיאה
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST api/<WarehouseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WarehouseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WarehouseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
