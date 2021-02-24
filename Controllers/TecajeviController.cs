using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Net;

namespace Vidly2.Controllers
{
    public class TecajeviController : Controller
    {
        private ApplicationDbContext _context;

        public TecajeviController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var tecajeviNovi = DohvatiTecajeve();

            _context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Tecajs]");

            foreach (var tecaj in tecajeviNovi)
            {
                _context.Tecajs.Add(tecaj);
            }

            _context.SaveChanges();
            
            var tecajeviInDb = _context.Tecajs.ToList();

            return View(tecajeviInDb);
        }

        public static List<Tecaj> DohvatiTecajeve()
        {
            var json = new WebClient().DownloadString("http://api.hnb.hr/tecajn/v2");
            List<Tecaj> tecajevi = JsonConvert.DeserializeObject<List<Tecaj>>(json);

            return tecajevi;
        }

    }
}
