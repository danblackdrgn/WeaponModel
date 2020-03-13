using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponEntities.Entity;
using WeaponEntities.Repository;
using WeaponEntities.RepositoryImpl;

namespace WeaponEntities.Services
{
    public class AxeService
    {
        IAxeRepository axeRepository;
        IEnchantmentRepository enchantmentRepository;
        public AxeService()
        {
            axeRepository = new AxeRepositoryImpl();
            enchantmentRepository = new EnchantmentRepositoryImpl();
        }

        public void AddNewAxe(Axe axeItem)
        {
            if(axeItem != null) { 
            Enchantment enchantmentItem = enchantmentRepository.GetEnchantmentById(3);
            axeItem.EnchantmentId = enchantmentItem.EnchantmentId;
            axeRepository.AddAxe(axeItem);
            }
        }


        public ICollection<Axe> GetAllAxes()
        {
            return axeRepository.GetAllAxes();
        }
    }
}
