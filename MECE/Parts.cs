using MonoMod;
using MonoMod.Utils;
using Quintessential;
using Quintessential.Components;
using Quintessential.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static Quintessential.PartCycleDelegate;
using Neuvolics;
namespace MECE;
using Lithos;
using SDL2;

internal class Parts
{
    //SECOND ORDER HALF METALS
    public static PartType Ascent, Conjurgation, Deconstruction;
    // HEAVY CARDINALS
    public static PartType Concurrence, Dissipation;
    // NEUVOLURGY
    public static PartType Convolution, Fragmentation;
    // METALLURGY
    public static PartType Shattering, Subjection;
    // ANIMISMUS
    public static PartType Judgement;

    private static readonly HexIndex conjurgationInput = new(-1, 0);
    private static readonly HexIndex conjurgationOutput = new(1, 0);
    private static readonly HexIndex conjurgationBuffer = new(0, 0);

    private static readonly HexIndex convolutionInput = new(-1, 2);
    private static readonly HexIndex convolutionBowl = new(0, 0);
    private static readonly HexIndex convolutionOutputGel = new(1, 0);
    private static readonly HexIndex convolutionOutputFrix = new(-1, 0);
    private static readonly HexIndex convolutionBlockerA = new(0, 1);
    private static readonly HexIndex convolutionBlockerB = new(-1, 1);

    private static readonly HexIndex fragmentationInput = new(1, 0);
    private static readonly HexIndex fragmentationOutputCW = new(0, -1);
    private static readonly HexIndex fragmentationOutputCCW = new(-1, 1);
    private static readonly HexIndex fragmentationBowl = new(-1, 0);
    private static readonly HexIndex fragmentationBlocker = new(0, 0);

    private static readonly HexIndex derivationInputA = new(1, -1);
    private static readonly HexIndex derivationInputB = new(0, -1);
    private static readonly HexIndex derivationOutput = new(0, 0);

    private static readonly HexIndex ascentBowl = new(0, 0);

    private static readonly HexIndex judgementBowlIn = new(-1, 0);
    private static readonly HexIndex judgementBowlOut = new(1, 0);
    private static readonly HexIndex judgementBlocker = new(0, 0);

    private static readonly HexIndex deconMediate = new(-1, 0);
    private static readonly HexIndex deconOutput = new(1, 0);
    private static readonly HexIndex deconInput = new(0, 0);

    private static readonly HexIndex shatterInput = new(0, 0);
    private static readonly HexIndex shatterOutLead = new(2, 0);
    private static readonly HexIndex shatterOutAnti = new(-2, 0);
    private static readonly HexIndex shatterBlockA = new(-2, 1);
    private static readonly HexIndex shatterBlockB = new(-1, 1);
    private static readonly HexIndex shatterBlockC = new(1, -1);
    private static readonly HexIndex shatterBlockD = new(2, -1);

    private static readonly HexIndex refractCenter = new(0, 0);
    private static readonly HexIndex refractIrisA = new(-1, 0);
    private static readonly HexIndex refractIrisB = new(0, 1);
    private static readonly HexIndex refractIrisC = new(1, -1);

    private static readonly HexIndex SubjectionHigh = new(0, 0);
    private static readonly HexIndex SubjectionLow = new(-1, 0);

    private static readonly HexIndex atwixInA = new(-1, 0);
    private static readonly HexIndex atwixOutA = new(0, 0);
    private static readonly HexIndex atwixOutB = new(1, 0);
    private static readonly HexIndex atwixInB = new(2, 0);

    private static readonly HexIndex ConcurOutput = new(0, 0);
    private static readonly HexIndex ConcurInA = new(0, -2);
    private static readonly HexIndex ConcurInB = new(2, -2);
    private static readonly HexIndex ConcurInC = new(2, -1);
    private static readonly HexIndex ConcurInD = new(-1, -1);
    private static readonly HexIndex ConcurBlockA = new(0, -1);
    private static readonly HexIndex ConcurBlockB = new(1, -1);

    private static readonly HexIndex DissInput = new(0, 0);
    private static readonly HexIndex DissBlockA = new(-1, 1);
    private static readonly HexIndex DissBlockB = new(1, -1);
    private static readonly HexIndex DissTerra = new(-1, 2);
    private static readonly HexIndex DissIgnis = new(0, 2);
    private static readonly HexIndex DissAqua = new(0, -2);
    private static readonly HexIndex DissCaelum = new(1, -2);

    private static readonly HexIndex RepositionA = new(0, 0);
    private static readonly HexIndex RepositionB = new(-1, 0);
    //faster!
    internal static Texture TexLoad(string path)
    {
        return AssetLoaderHelper.LoadTexture("textures/mece/parts/" + path);
    }
    
    public static void MakeParts()
    {
        Ascent = new()
        {
            cost = 10,
            isFullHexCover = true,
            glowTexture = TexLoad("ascent/glow"),
            strokeTexture = TexLoad("ascent/stroke"),
            baseTexture = TexLoad("icons/ascent"),
            hoverTexture = TexLoad("icons/ascent"),
            glyphHexes = [ascentBowl],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("ascent"))
        };
        Conjurgation = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("conjurgation/glow"),
            strokeTexture = TexLoad("conjurgation/stroke"),
            baseTexture = TexLoad("icons/conjurgation"),
            hoverTexture = TexLoad("icons/conjurgation"),
            glyphHexes = [conjurgationInput, conjurgationBuffer, conjurgationOutput],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("conjurgation"))
        };
        Deconstruction = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("deconstruction/glow"),
            strokeTexture = TexLoad("deconstruction/stroke"),
            baseTexture = TexLoad("icons/deconstruction"),
            hoverTexture = TexLoad("icons/deconstruction"),
            glyphHexes = [deconInput, deconMediate, deconOutput],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("deconstruction"))
        };
        Concurrence = new()
        {
            cost = 10,
            isFullHexCover = true,
            glowTexture = TexLoad("concurrence/glow"),
            strokeTexture = TexLoad("concurrence/stroke"),
            baseTexture = TexLoad("icons/concurrence"),
            hoverTexture = TexLoad("icons/concurrence"),
            glyphHexes = [ConcurInA, ConcurInB, ConcurInC, ConcurInD, ConcurOutput, ConcurBlockA, ConcurBlockB],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("concurrence"))
        };
        Dissipation = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("dissipation/glow"),
            strokeTexture = TexLoad("dissipation/stroke"),
            baseTexture = TexLoad("icons/dissipation"),
            hoverTexture = TexLoad("icons/dissipation"),
            glyphHexes = [DissInput, DissBlockA, DissBlockB, DissIgnis, DissAqua, DissCaelum, DissTerra],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("dissipation"))
        };
        Convolution = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("convolution/glow"),
            strokeTexture = TexLoad("convolution/stroke"),
            baseTexture = TexLoad("icons/convolution"),
            hoverTexture = TexLoad("icons/convolution"),
            glyphHexes = [conjurgationBuffer, convolutionBlockerA, convolutionBlockerB, convolutionBowl, convolutionInput, convolutionOutputFrix, convolutionOutputGel],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("convolution"))
        };
        Fragmentation = new()
        {
            cost = 10,
            isFullHexCover = true,
            glowTexture = TexLoad("fragmentation/glow"),
            strokeTexture = TexLoad("fragmentation/stroke"),
            baseTexture = TexLoad("icons/fragmentation"),
            hoverTexture = TexLoad("icons/fragmentation"),
            glyphHexes = [fragmentationBlocker, fragmentationBowl, fragmentationInput, fragmentationOutputCCW, fragmentationOutputCW],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("fragmentation"))
        };
        Shattering = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("shattering/glow"),
            strokeTexture = TexLoad("shattering/stroke"),
            baseTexture = TexLoad("icons/shattering"),
            hoverTexture = TexLoad("icons/shattering"),
            glyphHexes = [shatterBlockA, shatterBlockB, shatterBlockC, shatterBlockD, shatterInput, shatterOutAnti, shatterOutLead],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("shattering"))
        };
        Subjection = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("subjection/glow"),
            strokeTexture = TexLoad("subjection/stroke"),
            baseTexture = TexLoad("icons/subjection"),
            hoverTexture = TexLoad("icons/subjection"),
            glyphHexes = [SubjectionHigh, SubjectionLow],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("subjection"))
        };
        Judgement = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = TexLoad("judgement/glow"),
            strokeTexture = TexLoad("judgement/stroke"),
            baseTexture = TexLoad("icons/judgement"),
            hoverTexture = TexLoad("icons/judgement"),
            glyphHexes = [judgementBlocker, judgementBowlIn, judgementBowlOut],
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(MECE.Instance.GetIdentifier("judgement"))
        };


        MECE.Instance.AddPartType(Conjurgation, "conjugration", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseConjurgation, new Vector2(1f, 1f), new Vector2(125f, 48f), 0);
            renderer.RenderIris(ips, conjurgationOutput, time, pss.isProcessing ? pss.processingAtoms[0] : null);
            renderer.RenderRotating(Textures.Bowl, conjurgationBuffer, Vector2.Zero);
            Helpers.DrawHole(conjurgationInput, renderer);
            renderer.RenderUpright(Textures.pos_metal, conjurgationBuffer, Vector2.Zero);
            renderer.RenderUpright(Textures.pos_metal_hole, conjurgationInput, Vector2.Zero);
        });
        /* MECE.Instance.AddPartType(Derivation, static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseDerivation, new Vector2(0f, 0f), new Vector2(92f, 120f), 0);
            Helpers.DrawHole(derivationInputA, renderer);
            Helpers.DrawHole(derivationInputB, renderer);
            Brimstone.API.GetRenderingHelpers(part, pos, editor, out PartSimState pss, out PartDataWrapper pdw, out float time);
            renderer.RenderIris(ips, derivationOutput, time, pss.isProcessing ? (pss.processingAtoms[0]) : null);
            renderer.RenderUpright(Textures.triaPrimae, derivationInputA, Vector2.Zero);
            renderer.RenderUpright(Textures.triaPrimae, derivationInputB, Vector2.Zero);


        }); */
        MECE.Instance.AddPartType(Ascent, "acent", static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseAscent, new Vector2(0f, 0f), new Vector2(41f, 48f), 0);
            renderer.RenderRotating(Textures.Bowl, ascentBowl, Vector2.Zero);
            renderer.RenderUpright(Textures.second_order, ascentBowl, Vector2.Zero);

        });
        MECE.Instance.AddPartType(Deconstruction, "deconstruction", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseDeconstruction, new Vector2(0f, 0f), new Vector2(125f, 48f), 0);
            renderer.RenderRotating(Textures.Bowl, deconInput, Vector2.Zero);
            renderer.RenderRotating(Textures.Bowl, deconMediate, Vector2.Zero);
            renderer.RenderUpright(Textures.gold_titan, deconInput, Vector2.Zero);
            renderer.RenderIris(ips, deconOutput, time, pss.isProcessing ? pss.processingAtoms[0] : null);
        });
        MECE.Instance.AddPartType(Convolution, "convolution", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseConvolution, new Vector2(0f, 0f), new Vector2(125f, 190f), 0);
            Helpers.DrawHole(convolutionInput, renderer);
            renderer.RenderRotating(Textures.Bowl, convolutionBowl, Vector2.Zero);
            renderer.RenderIris(ips, convolutionOutputFrix, time,  pss.isProcessing ? pss.processingAtoms[0] : null );
            renderer.RenderIris(ips, convolutionOutputGel, time, pss.isProcessing ? pss.processingAtoms[1] : null );

        });
        MECE.Instance.AddPartType(Fragmentation, "fragmentation", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseFragmentation, new Vector2(0f, 0f), new Vector2(123f, 119f), 0);
            Helpers.DrawHole(fragmentationInput, renderer);
            renderer.RenderRotating(Textures.Bowl, fragmentationBowl, Vector2.Zero);
            renderer.RenderIris(ips, fragmentationOutputCW, time, pss.isProcessing ? pss.processingAtoms[0]: null);
            renderer.RenderIris(ips, fragmentationOutputCCW, time, pss.isProcessing ? pss.processingAtoms[1] : null);

        });
        MECE.Instance.AddPartType(Judgement, "judgement", static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseJudgement, new Vector2(0f, 0f), new Vector2(125f, 48f), 0);
            renderer.RenderRotating(Textures.Bowl, judgementBowlIn, Vector2.Zero);
            renderer.RenderRotating(Textures.Bowl, judgementBowlOut, Vector2.Zero);
            renderer.RenderUpright(Textures.judge_A, judgementBowlIn, Vector2.Zero);
            renderer.RenderUpright(Textures.judge_B, judgementBowlOut, Vector2.Zero);
        });
        MECE.Instance.AddPartType(Shattering, "shattering", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseShattering, new Vector2(0f, 0f), new Vector2(205f, 113f), 0);
            renderer.RenderRotating(Textures.Bowl, shatterInput, Vector2.Zero);
            renderer.RenderIris(ips, shatterOutAnti, time, pss.isProcessing ? pss.processingAtoms[1] : null);
            renderer.RenderIris(ips, shatterOutLead, time, pss.isProcessing ? pss.processingAtoms[0] : null);
            renderer.RenderUpright(Textures.vaca_only, shatterInput, Vector2.Zero);
        });

        /* MECE.Instance.AddPartType(Atwix, static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseAtwix, new Vector2(0f, 0f), new Vector2(125f, 48f), 0);
            Helpers.DrawHole(atwixInA, renderer);
            Helpers.DrawHole(atwixInB, renderer);
            Brimstone.API.GetRenderingHelpers(part, pos, editor, out PartSimState pss, out PartDataWrapper pdw, out float time);
            renderer.RenderIris(ips, atwixOutA, time, pss.isProcessing ? (pss.processingAtoms[0]) : null);
            renderer.RenderIris(ips, atwixOutB, time, pss.isProcessing ? (pss.processingAtoms[0]) : null);
            renderer.RenderUpright(Textures.cardinals, atwixInA, Vector2.Zero);
            renderer.RenderUpright(Textures.cardinals, atwixInB, Vector2.Zero);
        }); */

        /* MECE.Instance.AddPartType(Refraction, static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseRefraction, new Vector2(0f, 0f), new Vector2(123f, 118.5f), 0);
            Brimstone.API.GetRenderingHelpers(part, pos, editor, out PartSimState pss, out PartDataWrapper pdw, out float time);
            if (pss.processingAtoms != null)
            {
                if (pss.processingAtoms[0] != Vanilla.mors)
                {
                    renderer.RenderIris(ips, refractIrisA, time, pss.isProcessing ? (pss.processingAtoms[0]) : null);
                }
                else
                {
                    Helpers.DrawHole(refractIrisA, renderer);
                }
                if (pss.processingAtoms[1] != Vanilla.mors)
                {
                    renderer.RenderIris(ips, refractIrisB, time, pss.isProcessing ? (pss.processingAtoms[1]) : null);
                }
                else
                {
                    Helpers.DrawHole(refractIrisB, renderer);
                }
                if (pss.processingAtoms[2] != Vanilla.mors)
                {
                    renderer.RenderIris(ips, refractIrisC, time, pss.isProcessing ? (pss.processingAtoms[2]) : null);
                }
                else
                {
                    Helpers.DrawHole(refractIrisC, renderer);
                }
            }
            else
            {
                Helpers.DrawHole(refractIrisA, renderer);
                Helpers.DrawHole(refractIrisB, renderer);
                Helpers.DrawHole(refractIrisC, renderer);
            }
        }); */
        MECE.Instance.AddPartType(Subjection, "subjection", static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseSubjection, new Vector2(0f, 0f), new Vector2(123f, 48f), 0);
            renderer.RenderRotating(Textures.MetalBowl, SubjectionHigh, Vector2.Zero);
            renderer.RenderRotating(Textures.MetalBowl, SubjectionLow, Vector2.Zero);
            renderer.RenderUpright(Textures.subjectUp, SubjectionHigh, Vector2.Zero);
            renderer.RenderUpright(Textures.subjectDown, SubjectionLow, Vector2.Zero);
        });
        /* MECE.Instance.AddPartType(Reposition, static (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(Textures.baseReposition, new Vector2(0f, 0f), new Vector2(123f, 48f), 0);
            renderer.method_528(Textures.Bowl, RepositionA, Vector2.Zero);
            renderer.method_528(Textures.Bowl, RepositionB, Vector2.Zero);
            renderer.RenderUpright(Textures.repos_symbols, RepositionA, Vector2.Zero);
            renderer.RenderUpright(Textures.repos_symbols, RepositionB, Vector2.Zero);
        }); */

        MECE.Instance.AddPartType(Dissipation, "dissipation", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseDissipation, new Vector2(0f, 0f), new Vector2(123f, 189.5f), 0);
            Helpers.DrawHole(DissInput, renderer);

            renderer.RenderIris(ips, DissIgnis, time, pss.isProcessing ? (pss.processingAtoms[0]) : null);
            renderer.RenderIris(ips, DissAqua, time, pss.isProcessing ? (pss.processingAtoms[1]) : null);
            renderer.RenderIris(ips, DissTerra, time, pss.isProcessing ? (pss.processingAtoms[2]) : null);
            renderer.RenderIris(ips, DissCaelum, time, pss.isProcessing ? (pss.processingAtoms[3]) : null);
        });

        MECE.Instance.AddPartType(Concurrence, "concurence", static (part, pos, editor, renderer) =>
        {
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            IntermediatePartState ips = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            renderer.RenderBase(Textures.baseConcurrence, new Vector2(0f, 0f), new Vector2(164f, 189.5f), 0);
            Helpers.DrawHole(ConcurInA, renderer);
            Helpers.DrawHole(ConcurInB, renderer);
            Helpers.DrawHole(ConcurInC, renderer);
            Helpers.DrawHole(ConcurInD, renderer);

            renderer.RenderIris(ips, ConcurOutput, time, pss.isProcessing ? (pss.processingAtoms[0]) : null);
        });

        QApi.AddPartTypeToPanel(Ascent, false);
        QApi.AddPartTypeToPanel(Conjurgation, false);
        QApi.AddPartTypeToPanel(Deconstruction, false);
        QApi.AddPartTypeToPanel(Concurrence, false);
        QApi.AddPartTypeToPanel(Dissipation, false);
        QApi.AddPartTypeToPanel(Convolution, false);
        QApi.AddPartTypeToPanel(Fragmentation, false);
        QApi.AddPartTypeToPanel(Shattering, false);
        QApi.AddPartTypeToPanel(Subjection, false);
        QApi.AddPartTypeToPanel(Judgement, false);

    }

    public static void AddPermissions()
    {
        MECE.Instance.AddPuzzlePermission("ascent");
        MECE.Instance.AddPuzzlePermission("conjurgation");
        MECE.Instance.AddPuzzlePermission("deconstruction");
        MECE.Instance.AddPuzzlePermission("concurrence");
        MECE.Instance.AddPuzzlePermission("dissipation");
        MECE.Instance.AddPuzzlePermission("convolution");
        MECE.Instance.AddPuzzlePermission("fragmentation");
        MECE.Instance.AddPuzzlePermission("shattering");
        MECE.Instance.AddPuzzlePermission("subjection");
        MECE.Instance.AddPuzzlePermission("judgement");
    }
}
