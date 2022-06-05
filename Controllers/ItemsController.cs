using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VastInventory.Entities;
using VastInventory.Repositories;

namespace VastInventoryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ImemitemsRepository _repository;

        public ItemsController(ImemitemsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Item> GetAllItems()
        {
            if (_repository.GetAllItems().Count() == 0) return NotFound();
            return _repository.GetAll();
        }
    }
}