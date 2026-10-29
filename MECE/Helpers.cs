using Quintessential;
using System;


namespace MECE;

internal class Helpers
{
   public static void DrawHole(HexIndex Pos, PartRenderer renderer)
    {
        renderer.RenderRotating(Assets.textures.parts.output_shadow, Pos, Vector2.Zero);
        renderer.RenderRotating(Assets.textures.parts.output_ring, Pos, Vector2.Zero);
    }
}
