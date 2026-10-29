using Quintessential;
using System;
using UnstableElements;

namespace MECE;

internal class PlutoniumComponent : UnstableElements.RadioactiveAtomComponent
{
    //copy-pasted, it's all private so i couldnt use the direct one anyway
    private PlutoniumComponent() : base(PlutoniumDecayTimes, Atoms.Aluminium, PlutoniumPhaseRenderers) { }
    private static readonly int[] PlutoniumDecayTimes = { 2, 3, 3 };
    private static readonly PhaseRenderer[] PlutoniumPhaseRenderers = { RenderPlutoniumPhase0, RenderPlutoniumPhase1, RenderPlutoniumPhase2 };
    private static readonly Random PlutoniumShakeCounter = new(34859);

    internal static void Register()
    {

        QApi.AddComponentToAtom(Atoms.Plutonium.Id, (atom) => new PlutoniumComponent());
        QApi.AddComponentToAtomOnReplace(Atoms.Plutonium.Id, (atom, atomType) => new PlutoniumComponent());
    }

    private static void RenderPlutoniumPhase0(Action doRender, ref AtomType type, ref Vector2 translation, ref float scaleMultiplier, ref float opacityMultiplier, ref float height, ref float shadowStrength, ref float shadowOffset, ref float shadowAngle, Texture shadow, Texture overlayEffect, bool isOutputRender, SolutionEditorBase solutionEditor)
    {
        type = Atoms.Plutonium;
        doRender();
    }
    private static void RenderPlutoniumPhase1(Action doRender, ref AtomType type, ref Vector2 translation, ref float scaleMultiplier, ref float opacityMultiplier, ref float height, ref float shadowStrength, ref float shadowOffset, ref float shadowAngle, Texture shadow, Texture overlayEffect, bool isOutputRender, SolutionEditorBase solutionEditor)
    {
        type = Atoms.Plutonium1;
        translation += new Vector2(PlutoniumShakeCounter.GetFloat(-4, 4) / 4f, PlutoniumShakeCounter.GetFloat(-4, 4) / 4f);
        doRender();
    }
    private static void RenderPlutoniumPhase2(Action doRender, ref AtomType type, ref Vector2 translation, ref float scaleMultiplier, ref float opacityMultiplier, ref float height, ref float shadowStrength, ref float shadowOffset, ref float shadowAngle, Texture shadow, Texture overlayEffect, bool isOutputRender, SolutionEditorBase solutionEditor)
    {
        type = Atoms.Plutonium2;
        translation += new Vector2(PlutoniumShakeCounter.GetFloat(-4, 4) / 2f, PlutoniumShakeCounter.GetFloat(-4, 4) / 2f);
        doRender();
    }
}
