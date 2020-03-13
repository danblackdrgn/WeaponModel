using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponEntities.Entity;
using WeaponEntities.Services;

namespace WeaponModel
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACIONES
            AxeService axeService = new AxeService();
            Axe axe = new Axe();

            // ASIGNACION
            axe.Name = "Pharao Axe";
            axe.Attack = 100;
            axe.Handler = 3;

            // IAMADA AL SERVIZ
            axeService.AddNewAxe(axe);
            var axes = axeService.GetAllAxes();

            foreach (var axeItem in axes)
            {
                Console.WriteLine(axeItem.Name);
                Console.WriteLine(axeItem.Attack);
                Console.WriteLine(axeItem.Handler);
                Console.WriteLine(axeItem.Enchantment.Element);
                Console.WriteLine(axeItem.Enchantment.Level);
            }

            Console.ReadKey();
            
        }
    }
}
