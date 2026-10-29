using Quintessential;
using Quintessential.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MECE;

internal class Atoms
{

    public static AtomType Ignotum;
    // SECOND ORDER HALF METALS
    public static AtomType Aluminium, Cerium, Ferrum, Indium, Neodynium, Titanium;
    // HEAVY CARDINALS
    public static AtomType Aqua, Caelum, Ignis, Terra, Zenithite;
    // CURIOUSITY - CARDINALSb
    public static AtomType Humita, Temperum;
    // QUIX
    public static AtomType Quicklead, Quicktin, Quickiron, Quickgold;

    // just add all the atoms
    public static void AddAtoms()
    {
#pragma warning disable CS0618
        Ignotum = new()
        {
            byteId = 254, //not 255
            Id = MECE.Instance.GetIdentifier("ignotum"),
            name = MECE.Instance.Translate("atoms.ignotum"),
            elementalName = MECE.Instance.Translate("atoms.ignotum"),
            defaultName = MECE.Instance.Translate("atoms.ignotum").locDictionary[Language.English],
            shadow = AssetLoaderHelper.LoadTexture("ohno"),
            symbol = AssetLoaderHelper.LoadTexture("ohno"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("ohno"),
                shade = AssetLoaderHelper.LoadTexture("ohno"),
            }
        };
        //this one isnt added to molecule select
#pragma warning restore CS0618
        Ignis = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/ignis_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/ignis_symbol"),
            isGlassy = true,
            glassyTextures = new()
            {
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/ignis_base"),
                base2 = Assets.textures.atoms.elements.air_base2,
                fog = Assets.textures.atoms.elements.air_fog,

            }
        };
        Aqua = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/aqua_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/aqua_symbol"),
            isGlassy = true,
            glassyTextures = new()
            {
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/aqua_base"),
                base2 = Assets.textures.atoms.elements.air_base2,
                fog = Assets.textures.atoms.elements.air_fog,

            }
        };
        Caelum = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/caelum_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/caelum_symbol"),
            isGlassy = true,
            glassyTextures = new()
            {
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/caelum_base"),
                base2 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/caelum_base2"),
                fog = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/caelum_fog"),

            }
        };
        Terra = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/terra_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/terra_symbol"),
            isGlassy = true,
            glassyTextures = new()
            {
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/terra_base"),
                base2 = Assets.textures.atoms.elements.air_base2,
                fog = Assets.textures.atoms.elements.air_fog,

            }
        };
        Zenithite = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/zenithite_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/zenithite_symbol"),
            isPrismatic = true,
            prismaticTextures = new()
            {
                colors = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/zenithite_colors"),
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/zenithite_base"),
                rimlight = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/zenithite_colors"),
                colorsMask = Assets.textures.atoms.elements.quintessence_mask,
            }
        };
        Humita = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/humita_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/humita_symbol"),
            isGlassy = true,
            glassyTextures = new()
            {
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/humita_base"),
                base2 = Assets.textures.atoms.elements.air_base2,
                fog = Assets.textures.atoms.elements.air_fog,

            }
        };
        Temperum = new()
        {
            shadow = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/temperum_shadow"),
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/temperum_symbol"),
            isGlassy = true,
            glassyTextures = new()
            {
                base1 = AssetLoaderHelper.LoadTexture("textures/mece/atoms/cardinals/temperum_base"),
                base2 = Assets.textures.atoms.elements.air_base2,
                fog = Assets.textures.atoms.elements.air_fog,

            }
        };

        Quickgold = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quickgold_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quickgold_diffuse"),
                shade = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quickgold_shade"),
            }
        };
        Quickiron = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quickiron_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quickiron_diffuse"),
                shade = Assets.textures.atoms.salt_shade,
            }
        };
        Quicktin = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quicktin_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quicktin_diffuse"),
                shade = Assets.textures.atoms.salt_shade,
            }
        };
        Quicklead = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quicklead_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quicklead_diffuse"),
                shade = AssetLoaderHelper.LoadTexture("textures/mece/atoms/quix/quicklead_shade"),
            }
        };

        Aluminium = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/aluminium_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/aluminium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Indium = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/indium_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/indium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Ferrum = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/ferrum_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = Assets.textures.atoms.iron_lightramp,
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Cerium = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/cerium_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/cerium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Neodynium = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/neodynium_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/neodynium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Titanium = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/titanium_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/titanium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };

        MECE.Instance.AddAtomType(Ignis, "ignis");
        MECE.Instance.AddAtomType(Aqua, "aqua");
        MECE.Instance.AddAtomType(Terra, "terra");
        MECE.Instance.AddAtomType(Caelum, "caelum");
        MECE.Instance.AddAtomType(Zenithite, "zenithite");
        MECE.Instance.AddAtomType(Humita, "humita");
        MECE.Instance.AddAtomType(Temperum, "temperum");

        MECE.Instance.AddAtomType(Quickgold, "quickgold");
        MECE.Instance.AddAtomType(Quickiron, "quickiron");
        MECE.Instance.AddAtomType(Quicktin, "quicktin");
        MECE.Instance.AddAtomType(Quicklead, "quicklead");

        MECE.Instance.AddAtomType(Aluminium, "aluminium");
        MECE.Instance.AddAtomType(Indium, "indium");
        MECE.Instance.AddAtomType(Ferrum, "ferrum");
        MECE.Instance.AddAtomType(Cerium, "cerium");
        MECE.Instance.AddAtomType(Neodynium, "neodynium");
        MECE.Instance.AddAtomType(Titanium, "titanium");
    }

    public static AtomType Plutonium, Plutonium1, Plutonium2;
    public static void AddPlutoniumSpecifically()
    {
        Plutonium = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/placeholder_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/plutonium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Plutonium1 = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/placeholder_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/plutonium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        Plutonium2 = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/mece/atoms/placeholder_symbol"),
            isMetallic = true,
            metallicTextures = new()
            {
                lightramp = AssetLoaderHelper.LoadTexture("textures/mece/atoms/SOHM/plutonium_lightramp"),
                diffuse = Assets.textures.atoms.salt_diffuse,
                rimlight = Assets.textures.atoms.iron_rimlight
            }
        };
        MECE.Instance.AddAtomType(Plutonium, "plutonium");
    }
}
