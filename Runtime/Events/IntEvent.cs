using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     A ScriptableObject representing an event that carries an integer payload.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The IntEvent class is a concrete implementation of the Event class for integer payloads.
    ///         It can be used to create events in the Unity Editor that are specifically designed
    ///         to handle integer data. This is useful for events that require numeric information,
    ///         such as scoring, counting, or any other numerical changes in a game.
    ///     </para>
    ///     <para>
    ///         To use this class, create an IntEvent asset in the Unity Editor. Listeners can be
    ///         registered to respond to the event, and the event can be invoked with an integer
    ///         value to notify all listeners.
    ///     </para>
    /// </remarks>
    [CreateAssetMenu(menuName = Framework.Events.Int, fileName = nameof(IntEvent), order = Framework.MenuOrders.Int)]
    public sealed class IntEvent : Event<int>
    {
    }
}