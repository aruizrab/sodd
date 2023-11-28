using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     A ScriptableObject representing an event that carries a Vector3 payload.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The Vector3Event class extends the Event class for events that specifically handle three-dimensional
    ///         vector data (Vector3). It is tailored for scenarios where 3D coordinates, directions, or other vector-based
    ///         information in a three-dimensional space are integral to the event's purpose.
    ///     </para>
    ///     <para>
    ///         Use this class to create and manage events involving 3D vector data within the Unity Editor. By registering
    ///         listeners to a Vector3Event, developers can respond dynamically to changes or updates represented by Vector3
    ///         values, such as position updates, movement directions, or spatial calculations.
    ///     </para>
    ///     <para>
    ///         Vector3Event assets can be created and configured in the Unity Editor, enabling flexible and responsive event
    ///         handling in various aspects of 3D game or application development.
    ///     </para>
    /// </remarks>
    [CreateAssetMenu(menuName = Framework.Events.Vector3, fileName = nameof(Vector3Event),
        order = Framework.MenuOrders.Vector3)]
    public sealed class Vector3Event : Event<Vector3>
    {
    }
}