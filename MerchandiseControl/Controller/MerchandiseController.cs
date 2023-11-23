using MerchandiseControl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchandiseController : ControllerBase
    {
        private readonly IMerchandiseRepository _merchandiseRepository;

        public MerchandiseController(IMerchandiseRepository merchandiseRepository)
        {
           _merchandiseRepository = merchandiseRepository ?? throw new ArgumentNullException(nameof(MerchandiseRepository));
        }

        public IActionResult Add(MerchandiseViewModel merchandiseView){
            var merchandise = new Merchandise(merchandiseView.name, merchandiseView.price, null);
            _merchandiseRepository.add(merchandise);
            return Ok();
        }
    }
}
