using System.Collections.Generic;
using WeaponEntities.Entity;

namespace WeaponEntities.Repository
{
    interface IAxeRepository
    {
        bool AddAxe (Axe AxeItem);
        bool UpdateAxe (int AxeId);
        bool DeleteAxe(int AxeId);
        Axe GetAxeByName (string AxeName);
        ICollection<Axe> GetAllAxesByEnchantment(int EnchantmentId);
        ICollection<Axe> GetAllAxes();
    }
}
