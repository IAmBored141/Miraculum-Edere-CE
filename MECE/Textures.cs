using Quintessential;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MECE;

internal class Textures
{
    public static Texture[] glyphEffect = Assets.textures.parts.glyph_flash;

    public static readonly Texture[] transmuteCalcify = Assets.textures.atoms.calcify_mask;
    public static readonly Texture[] transmuteDupe = Assets.textures.atoms.duplicate_mask;

    public static readonly Texture Hole_Shadow = AssetLoaderHelper.LoadTexture("textures/parts/output_shadow");
    public static readonly Texture Bowl = AssetLoaderHelper.LoadTexture("textures/parts/calcinator_bowl");

    public static readonly Texture MetalBowl = AssetLoaderHelper.LoadTexture("textures/parts/projection_glyph/metal_bowl");
    
    //bases
    public static readonly Texture baseConjurgation = AssetLoaderHelper.LoadTexture("textures/mece/parts/conjurgation/base");
    public static readonly Texture baseDerivation = AssetLoaderHelper.LoadTexture("textures/mece/parts/derivation/base");
    public static readonly Texture baseAscent = AssetLoaderHelper.LoadTexture("textures/mece/parts/ascent/base");
    public static readonly Texture baseDeconstruction = AssetLoaderHelper.LoadTexture("textures/mece/parts/deconstruction/base");
    public static readonly Texture baseConvolution = AssetLoaderHelper.LoadTexture("textures/mece/parts/convolution/base");
    public static readonly Texture baseFragmentation = AssetLoaderHelper.LoadTexture("textures/mece/parts/fragmentation/base");
    public static readonly Texture baseJudgement = AssetLoaderHelper.LoadTexture("textures/mece/parts/judgement/base");
    public static readonly Texture baseShattering = AssetLoaderHelper.LoadTexture("textures/mece/parts/shattering/base");
    public static readonly Texture baseRefraction = AssetLoaderHelper.LoadTexture("textures/mece/parts/refraction/base");
    public static readonly Texture baseSubjection = AssetLoaderHelper.LoadTexture("textures/mece/parts/subjection/base");
    public static readonly Texture baseAtwix = AssetLoaderHelper.LoadTexture("textures/mece/parts/atwix/base");
    public static readonly Texture baseDissipation = AssetLoaderHelper.LoadTexture("textures/mece/parts/dissipation/base");
    public static readonly Texture baseConcurrence = AssetLoaderHelper.LoadTexture("textures/mece/parts/concurrence/base");
    public static readonly Texture baseReposition = AssetLoaderHelper.LoadTexture("textures/mece/parts/reposition/base");

    public static readonly Texture subjectUp = AssetLoaderHelper.LoadTexture("textures/mece/parts/subjection/arrow_up");
    public static readonly Texture subjectDown = AssetLoaderHelper.LoadTexture("textures/mece/parts/subjection/arrow_down");
    public static readonly Texture gold_titan = AssetLoaderHelper.LoadTexture("textures/mece/parts/deconstruction/gold_titanium");
    public static readonly Texture second_order = AssetLoaderHelper.LoadTexture("textures/mece/parts/ascent/second_order");
    public static readonly Texture pos_metal = AssetLoaderHelper.LoadTexture("textures/mece/parts/conjurgation/pos_metal");
    public static readonly Texture pos_metal_hole = AssetLoaderHelper.LoadTexture("textures/mece/parts/conjurgation/pos_metal_hole");
    public static readonly Texture vaca_only = AssetLoaderHelper.LoadTexture("textures/mece/parts/shattering/vaca");
    public static readonly Texture judge_A = AssetLoaderHelper.LoadTexture("textures/mece/parts/judgement/judgeA");
    public static readonly Texture judge_B = AssetLoaderHelper.LoadTexture("textures/mece/parts/judgement/judgeB");
    public static readonly Texture repos_symbols = AssetLoaderHelper.LoadTexture("textures/mece/parts/reposition/symbolRepos");

    public static readonly Texture cardinals = AssetLoaderHelper.LoadTexture("textures/mece/parts/atwix/cardinals");
}
