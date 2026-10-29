using Quintessential;
using UnstableElements;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MECE;

internal class Compat
{
    public static void AddPlutoniumRecipe()
    {
        //(archived bc yes)
        //Assembly UEAssembly = typeof(UnstableElements.UeApi).Assembly;
        //string UEName = UEAssembly.GetName().Name;
        //string UELetMeIn = "UnstableElements.Parts, " + UEName;
        //Logger.Log(UELetMeIn);

        // LET ME IN
        // LET ME IN
        // LET ME IN
        // LET ME IN
        
        [UnsafeAccessor(UnsafeAccessorKind.StaticField, Name = "Irradiation")]
        extern static ref PartType GetStaticField([UnsafeAccessorType("UnstableElements.Parts, Lightning")] object PartType);
        PartType UEIrradiation = GetStaticField("Irradiation");
        MECE.Instance.AddRecipe(new(PlutoniumRecipe), MECE.Instance.GetIdentifier("irradiation"), UEIrradiation.Id);
        PlutoniumComponent.Register();
    }
    public static bool PlutoniumRecipe(Sim sim, Part part)
    {
        //copy-pasted
        if (!sim.GetAtomReference(part, new(-1, 1), false, out var qs1) ||
            qs1.inMultiAtomMolecule || qs1.isHeldByArm || qs1.atomType != AtomTypes.quicksilver ||
            !sim.GetAtomReference(part, new(1, 0), false, out var qs2) ||
            qs2.inMultiAtomMolecule || qs2.isHeldByArm || qs2.atomType != AtomTypes.quicksilver ||
            !sim.GetAtomReference(part, new(0, -1), false, out var qs3) ||
            qs3.inMultiAtomMolecule || qs3.isHeldByArm || qs3.atomType != AtomTypes.quicksilver ||
            !sim.GetAtomReference(part, new(0, 0), false, out var gold) ||
            gold.atomType != Atoms.Titanium) return false;

        sim.RecipeInputs[new(0, 0)] = gold;
        sim.RecipeInputs[new(-1, 1)] = qs1;
        sim.RecipeInputs[new(1, 0)] = qs2;
        sim.RecipeInputs[new(0, -1)] = qs3;
        sim.RecipeOutputs[new(0, 0)] = Atoms.Plutonium;
        return true;
    }
}
