using Quintessential;

namespace MECE;

internal class MECE : QuintessentialMod, IDataMod {
    public static MECE Instance { get; }
    public override string ModId => "mece";

    public override void Load() {
    }

    public override void LoadContent() {
        Atoms.AddAtoms();
        Parts.MakeParts();
    }
    public override void LoadCompatContent() {
        if (QuintessentialLoader.IsModPresent("unstable_elements"))
        {
            Atoms.AddPlutoniumSpecifically();
            Compat.AddPlutoniumRecipe();
        }
        Parts.AddPermissions();
    }
    public override void FinaliseContent() { }

    public override void PostLoad() { }
	public override void Unload() { }
}
