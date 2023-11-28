using UnityEngine;

namespace SODD.Listeners
{
    /// <summary>
    ///     A MonoBehaviour that listens to events of type bool and responds to them.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The BoolEventListener class is a specialized event listener for boolean-based events.
    ///         It extends the functionality of the generic EventListener class to handle events
    ///         that carry boolean (true/false) data.
    ///     </para>
    ///     <para>
    ///         This component can be attached to any GameObject in a Unity scene. It allows for
    ///         the configuration of the target event and response actions in the Unity Editor.
    ///         When the target event is invoked, this listener will trigger the defined UnityEvent
    ///         actions.
    ///     </para>
    ///     <para>
    ///         It is especially useful in scenarios where binary decisions or state changes are needed,
    ///         such as toggling visibility, activating/deactivating game objects, or triggering
    ///         state-specific behaviors in response to game events.
    ///     </para>
    /// </remarks>
    [AddComponentMenu(Framework.EventListeners.BoolEventListener, Framework.MenuOrders.Bool)]
    public class BoolEventListener : EventListener<bool>
    {
    }
}