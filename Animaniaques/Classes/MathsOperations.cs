using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaniaques.Classes
{
    class MathsOperations : ObservableCollection<Maths>
    {
        public MathsOperations() { }

        public void AddOperation(Maths C)
        {
            this.Add(C);
        }

        public void DeleteOperation(Maths C)
        {
            this.Remove(C);
        }
    }
}
