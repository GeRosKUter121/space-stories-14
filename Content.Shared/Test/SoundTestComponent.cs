namespace Content.Shared.Test;

[RegisterComponent]
public sealed partial class SoundTestComponent : Component
{
    [DataField]
    public LocId Text = "Hello, World!!!";
}
