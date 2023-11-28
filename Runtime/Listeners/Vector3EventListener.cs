using UnityEngine;

namespace SODD.Listeners
{
    /// <summary>
    ///     A MonoBehaviour that listens to events of type Vector3 and responds to them.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The Vector3EventListener class is a specialized event listener for handling events that carry
    ///         three-dimensional vector data (Vector3). This class extends the generic EventListener to provide
    ///         specific functionality for Vector3 events.
    ///     </para>
    ///     <para>
    ///         Attach this component to any GameObject in a Unity scene to enable it to listen to Vector3-based events.
    ///         In the Unity Editor, you can configure the target event and the response actions. When the target event
    ///         is invoked, this listener will trigger the specified UnityEvent actions, allowing for dynamic and
    ///         responsive behavior based on three-dimensional vector data.
    ///     </para>
    ///     <para>
    ///         This listener is particularly useful in scenarios involving spatial interactions, such as responding to
    ///         position changes, movement directions, or other 3D spatial events in a game or application.
    ///     </para>
    /// </remarks>
    [AddComponentMenu(Framework.EventListeners.Vector3EventListener, Framework.MenuOrders.Vector3)]
    public class Vector3EventListener : EventListener<Vector3>
    {
    }
}