using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace AccubookCandidateProject.Controllers
{
    public class BookingsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class BookingsApiController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/bookings")]
        public async Task<IHttpActionResult> GetBookings()
        {
            // your code goes here

            return Ok();
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/booking")]
        public async Task<IHttpActionResult> PostBooking()
        {
            // your code goes here

            return Ok();
        }
    }
}