using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfFour.CoR.Interfaces
{
    public interface ICoR<T>
    {
        T nextTemplate { get; set; }

        bool isCorrectTemplate();
    }
}
