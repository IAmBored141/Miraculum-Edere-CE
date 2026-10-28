using Quintessential;

namespace MECE;

internal class MECE : QuintessentialMod, IDataMod {
    public static MECE Instance { get; }
    public override string ModId => "mece";

    public override void Load() { }

    public override void LoadContent() {
        Atoms.AddAtoms();
    }
    public override void LoadCompatContent() { }
    public override void FinaliseContent() { }

    public override void PostLoad() { }
	public override void Unload() { }
}
