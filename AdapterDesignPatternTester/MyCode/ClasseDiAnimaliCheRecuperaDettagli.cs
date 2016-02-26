using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class ClasseDiAnimaliCheRecuperaDettagli: ClasseDiAnimali
    {
        private DescrittoreDettagliatoDiAnimali _sorgenteDati;
        
        public ClasseDiAnimaliCheRecuperaDettagli(TipoDiClasseDiAnimali tipoDiClasseDiAnimali) :
            base(tipoDiClasseDiAnimali)
        {
        }

        public override void DescriviClasseDiAnimali()
        {
            // The Adpatee
            _sorgenteDati = new DescrittoreDettagliatoDiAnimali();
            base.DescriviClasseDiAnimali();
            _sorgenteDati.DescriviClasseDiAnimaliInManieraDettagliataInBaseAllaClasse(_tipoDiClasseDiAnimale);
        }
    }
}
