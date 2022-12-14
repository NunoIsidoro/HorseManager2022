using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseManager2022.Interfaces
{
    public interface IDefinable
    {
        int id { get; set; }

        string ToSaveFormat();
    }

}
