// [ApiController]
//  [Route("api/[controller]")]
//  public class ProductsController : ControllerBase
//     {
       
//         private readonly ProductsDbContext _context; // your database context

//         public ProductsController(ProductsDbContext context)
//         {
//             _context = context;
//         }

//         [HttpGet]
//         public IEnumerable<Product> Get()
//         {
//            return _context.Products.ToList();
//         }
//     }