using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;
namespace HallOfBeorn.Services.LotR
{
    public interface ICharacterRepository
    {
        bool Exists(string name);
        Character Lookup(string name);
        IEnumerable<Character> All();
    }
}
