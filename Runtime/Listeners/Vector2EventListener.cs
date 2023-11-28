using UnityEngine;

namespace SODD.Listeners
{
    /// <summary>
    ///     A MonoBehaviour that listens to events of type Vector2 and responds to them.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The Vector2EventListener class is a specialized event listener for events that carry a Vector2 payload.
    ///         It extends the functionality of the generic EventListener class to handle events
    ///         related to 2D vector data, such as positions, directions, or any other 2D numerical data.
    ///     </para>
    ///     <para>
    ///         This component can be attached to any GameObject in a Unity scene. It allows for
    ///         the configuration of the target event and response actions in the Unity Editor.
    ///         When the target event is invoked, this listener will trigger the defined UnityEvent
    ///         actions, responding to the Vector2 data passed through the event.
    ///     </para>
    ///     <para>
    ///         It is particularly useful in scenarios where you need to respond to events that involve
    ///         2D coordinates, directions, or any other Vector2-based information, providing flexibility
    ///         and convenience in handling these types of events within the Unity environment.
    ///     </para>
    /// </remarks>
    [AddComponentMenu(Framework.EventListeners.Vector2EventListener, Framework.MenuOrders.Vector2)]
    public class Vector2EventListener : EventListener<Vector2>
    {
    }
}