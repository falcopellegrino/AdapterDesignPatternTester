using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class DescrittoreDettagliatoDiAnimali
    {
        public void DescriviClasseDiAnimaliInManieraDettagliataInBaseAllaClasse(TipoDiClasseDiAnimali tipoDiClasseDiAnimali)
        {
            switch (tipoDiClasseDiAnimali)
            {
                case TipoDiClasseDiAnimali.Pesci:
                    Console.WriteLine("Con il termine pesci, dal latino pisces, si intende un gruppo eterogeneo di organismi fondamentalmente acquatici, che nelle vecchie tassonomie assurgeva a classe sistematica dei vertebrati. I pesci, con oltre 32 000 specie coprono quasi il 50% del totale delle specie del subphylum vertebrata.");
                    break;
                case TipoDiClasseDiAnimali.Anfibi:
                    Console.WriteLine("Gli anfibi (Amphibia Blainville, 1816) sono una classe di animali vertebrati appartenente al phylum Chordata.");
                    break;
                case TipoDiClasseDiAnimali.Rettili:
                    Console.WriteLine("Rettili (Reptilia Laurenti, 1768), dal latino reptilis = \"strisciante\", rappresentarono la prima classe di vertebrati svincolatasi dall'ambiente acquatico e quindi adattata, per le fondamentali funzioni biologiche, alla vita in un ambiente strettamente terrestre. Il numero di specie di rettili attualmente viventi è di circa 9952.");
                    break;
                case TipoDiClasseDiAnimali.Uccelli:
                    Console.WriteLine("Gli uccelli (Aves Linnaeus, 1758) sono una classe di vertebrati endotermi cladisticamente riconducile a un ramo dei dinosauri teropodi[2][3] caratterizzati dalla presenza di becchi sdentati e forcule, corpi ricoperti di piumaggio e ripieni di sacchi aeriferi, dita anteriori fuse, uova dai gusci duri, metabolismi alti, e ossa cave ma robuste. In base a diversi criteri di classificazione, il numero di specie di uccelli conosciute oscilla fra le 9.000 e le 10.500[4], delle quali almeno 120 si sono estinte in tempi storici.");
                    break;
                case TipoDiClasseDiAnimali.Mammiferi:
                    Console.WriteLine("I mammiferi (Mammalia Linnaeus, 1758) sono una classe di animali vertebrati a diffusione cosmopolita.");
                    break;
                default:
                    Console.WriteLine("Nessun dettaglio.");
                    break;

            }
        }
    }
}
