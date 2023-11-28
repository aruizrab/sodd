using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     A ScriptableObject representing an event that carries a Vector2 payload.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The Vector2Event class is a specialized implementation of the Event class, designed for events
    ///         that carry a Vector2 (two-dimensional vector) payload. It is ideal for events that need to transmit
    ///         or respond to two-dimensional data, such as coordinates, directions, or any other two-dimensional
    ///         vector values within a game or application.
    ///     </para>
    ///     <para>
    ///         This class allows for the creation of Vector2-based events in the Unity Editor. Listeners can te registered to
    ///         these events, which will be invoked with a Vector2 value, facilitating dynamic and
    ///         responsive event handling involving two-dimensional vector data.
    ///     </para>
    /// </remarks>
    [CreateAssetMenu(menuName = Framework.Events.Vector2, fileName = nameof(Vector2Event),
        order = Framework.MenuOrders.Vector2)]
    public sealed class Vector2Event : Event<Vector2>
    {
    }
}