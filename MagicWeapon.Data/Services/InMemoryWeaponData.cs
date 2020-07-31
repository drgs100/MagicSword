using System.Collections.Generic;
using System.Linq;
using MagicWeapon.Data.Models;

namespace MagicWeapon.Data.Services
{
    public class InMemoryWeaponData : IWeaponData
    {
        List<MagicWeapons> magicWeapons;

        public InMemoryWeaponData()
        {
            magicWeapons = new List<MagicWeapons>()
            {
                new MagicWeapons { Id = 1, Name = "Fire sword", Type = WeaponType.Sword },
                new MagicWeapons { Id = 2, Name = "Flighty bow", Type = WeaponType.Bow },
                new MagicWeapons { Id = 3, Name = "+1 staff", Type = WeaponType.Staff },
            };
        }

        public IEnumerable<MagicWeapons> GetAll()
        {
            return magicWeapons.OrderBy(n => n.Name);
        }
    }
}