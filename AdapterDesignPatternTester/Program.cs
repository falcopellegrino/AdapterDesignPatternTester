using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = AdapterDesignPatternTester.StructuralCode;
using Real = AdapterDesignPatternTester.RealWorldCode;
//using Structural = AdapterDesignPatternTester.StructuralCode;

namespace AdapterDesignPatternTester
{
    // Definition
    // Convert the interface of a class into another interface clients expect.
    // Adapter lets classes work together that couldn't otherwise because of incompatible interfaces. 

    // Participants
    // The classes and objects participating in this pattern are:
    //  - Target (ChemicalCompound)
    //      --> defines the domain-specific interface that Client uses.
    //  - Adapter (Compound)
    //      --> adapts the interface Adaptee to the Target interface.
    //  - Adaptee (ChemicalDatabank)
    //      --> defines an existing interface that needs adapting. 
    //  - Client (AdapterApp)
    //      --> collaborates with objects conforming to the Target interface. 

    /// <summary>
    /// Mainapp startup class for
    /// Adapter Design Pattern
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Adapter pattern which maps the interface of one class onto another so that they can work together.
            // These incompatible classes may come from different libraries or frameworks.

            // Create adapter and place a request
            Structural.Target target = new Structural.Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real world code in C#
            // This real-world code demonstrates the use of a legacy chemical databank.
            // Chemical compound objects access the databank through an Adapter interface. 

            // Non adapted chemical compound
            Real.Compound unknown = new Real.Compound("unknown");
            unknown.Display();

            // Adapter chemical compounds
            Real.Compound water = new Real.RichCompound("Water");
            water.Display();

            Real.Compound benzene = new Real.RichCompound("Benzene");
            benzene.Display();

            Real.Compound ethanol = new Real.RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
            #endregion

            #region My code in C#
            #endregion
        }
    }
}
