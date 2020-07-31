using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicWeapon.Data.Models;

namespace MagicWeapon.Data.Services
{
    public interface IWeaponData
    {
        IEnumerable<MagicWeapons> GetAll();
    }
}
