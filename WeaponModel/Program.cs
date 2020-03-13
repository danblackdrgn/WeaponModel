using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponEntities.Entity;

namespace WeaponModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WeaponDb())
            {
                Axe axe = new Axe();
                axe.Name = "Stonecutter Axe";
                axe.Attack = 50;
                axe.Handler = 1;
                db.Axes.Add(axe);
                db.SaveChanges();

                var axes = from a in db.Axes
                           orderby a.Name
                           select a;

                Console.WriteLine("All Axes in database");
                foreach (var axeItem in axes)
                {
                    Console.WriteLine(axeItem.Name);
                    Console.WriteLine(axeItem.Attack);
                }
                Console.ReadKey();
            }
        }
    }
}
