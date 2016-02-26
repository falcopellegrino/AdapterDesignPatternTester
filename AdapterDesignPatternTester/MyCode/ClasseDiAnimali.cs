using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    class ClasseDiAnimali
    {
        protected TipoDiClasseDiAnimali _tipoDiClasseDiAnimale;

        // Constructor
        public ClasseDiAnimali(TipoDiClasseDiAnimali tipoDiClasseDiAnimale)
        {
            this._tipoDiClasseDiAnimale = tipoDiClasseDiAnimale;
        }

        public virtual void DescriviClasseDiAnimali()
        {
            Console.WriteLine("\nQuesta classe di animali è: {0}.", _tipoDiClasseDiAnimale.ToString());
        }
    }

}
