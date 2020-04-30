using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Net;

namespace CIC_WEB.Controllers
{
    public class HomeController : Controller
    {
        private ServiceContext _db = new ServiceContext();
        private ProjectContext db = new ProjectContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = (from p in db.Projects.OrderByDescending(i => i.Id)
                        select p).Take(6);

            return View(data.ToList());
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Project()
        {
            var data = (from p in db.Projects.OrderByDescending(i => i.Id)
                        select p).Take(6);

            return View(data.ToList());
        }
        public ActionResult Element()
        {
            return View();
        }
        public ActionResult Services()
        {
            var data = (from p in _db.Services.OrderByDescending(i => i.Id)
                        select p).Take(6);

            return View(data.ToList());
        }
        public ActionResult ProjectsDetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }
        public ActionResult ServicesDetail(int? id)
        {


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = _db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }
        
        public ActionResult SimpleBlog()
        {
            return View();
        }

    }
}