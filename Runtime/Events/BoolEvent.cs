using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     A ScriptableObject representing an event that carries a boolean payload.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The BoolEvent class is a concrete implementation of the Event class for boolean payloads.
    ///         It is designed to create events that handle boolean data, useful for scenarios such as toggling states,
    ///         triggering binary (on/off) behaviors, or any other situations where a true/false value is needed.
    ///     </para>
    ///     <para>
    ///         To use this class, create a BoolEvent asset in the Unity Editor. You can then register listeners
    ///         to respond to the event, and the event can be invoked with a boolean value to notify all listeners.
    ///     </para>
    /// </remarks>
    [CreateAssetMenu(menuName = Framework.Events.Bool, fileName = nameof(BoolEvent), order = Framework.MenuOrders.Bool)]
    public sealed class BoolEvent : Event<bool>
    {
    }
}