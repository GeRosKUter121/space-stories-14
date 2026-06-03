using System.Runtime.CompilerServices;
using Content.Shared.Interaction.Events;
using Content.Shared.Popups;
using Content.Shared.Test;
using Content.Shared.Trigger.Components.Triggers;
using DependencyAttribute = Robust.Shared.IoC.DependencyAttribute;

namespace Content.Server.Test;

public sealed class TestSoundSystem : EntitySystem
{
    [Dependency] private SharedPopupSystem _popup = default!;
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SoundTestComponent, UseInHandEvent>(OnUseInHand);

    }
    private void OnUseInHand(Entity<SoundTestComponent> entity, ref UseInHandEvent args)
    {
        _popup.PopupEntity(Loc.GetString(entity.Comp.Text), entity.Owner);
    }
}
