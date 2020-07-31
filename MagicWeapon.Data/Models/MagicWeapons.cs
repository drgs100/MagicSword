using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWeapon.Data.Models
{
    public class MagicWeapons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WeaponType Type { get; set; }
    }
}
