using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // інтерфейс містить абстрактну поведінку (неявно абстрактні та неявно відкриті методи, властивості), може містити константи
    internal interface IWalk
    {
        const string activity = "Walking";
        void Walk();
    }
}
