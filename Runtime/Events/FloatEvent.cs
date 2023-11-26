using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     A ScriptableObject representing an event that carries a floating-point number as its payload.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The FloatEvent class is a concrete implementation of the Event class for floating-point number payloads.
    ///         It is used to create events in the Unity Editor that specifically handle float data.
    ///         This class is useful for events that involve numerical values that require precision,
    ///         such as time, speed, percentages, or any other measurements that use floating-point representation.
    ///     </para>
    ///     <para>
    ///         To use this class, create a FloatEvent asset in the Unity Editor. Listeners can be
    ///         registered to respond to the event, and the event can be invoked with a
    ///         float value to notify all listeners.
    ///     </para>
    /// </remarks>
    [CreateAssetMenu(menuName = Framework.Events.Float, fileName = nameof(FloatEvent),
        order = Framework.MenuOrders.Float)]
    public sealed class FloatEvent : Event<float>
    {
    }
}