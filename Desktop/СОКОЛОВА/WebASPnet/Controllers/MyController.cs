using Microsoft.AspNetCore.Mvc;
using WebASPnet.Models;

namespace WebASPnet.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public IActionResult FirstViewMethod()
        {
            List<Vegetable> vegetables = GetVegetablesList();
            return View(vegetables);
        }
        public ActionResult SecondViewMethod()
        {
            var vegetables = GetVegetablesList().OrderBy(x => x.Name).ToList();
            return View(vegetables);
        }
        public ActionResult ThridViewMethod()
        {
            var vegetables = GetVegetablesList().OrderBy(x => x.Name).ToList();
            return View(vegetables);
        }


        public List<Vegetable> GetVegetablesList()
        {
            List<Vegetable> plants = new List<Vegetable>();
            StreamReader StreamIn = new StreamReader("Vegetable.txt"); 
            string Str;
            for (int i = 1; (Str = StreamIn.ReadLine()) != null; i++)
            {
                string[] Veget = Str.Split('|');
                plants.Add(new Vegetable {Name = Veget[0].Trim(), Price = double.Parse(Veget[1])});
            }
            StreamIn.Close(); 
            return plants;
        }


    }
}
