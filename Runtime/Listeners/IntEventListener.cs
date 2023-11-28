using UnityEngine;

namespace SODD.Listeners
{
    /// <summary>
    ///     A MonoBehaviour that listens to events of type int and responds to them.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The IntEventListener class is a specialized event listener for integer-based events.
    ///         It inherits from the generic EventListener class, providing functionality
    ///         specific to integer events.
    ///     </para>
    ///     <para>
    ///         This component can be attached to any GameObject in a Unity scene. Configure the
    ///         target event and response in the Unity Editor. When the target event is invoked,
    ///         this listener will execute the configured actions.
    ///     </para>
    ///     <para>
    ///         It is particularly useful for responding to events that carry integer data,
    ///         such as score updates, count changes, or other numeric-related events.
    ///     </para>
    /// </remarks>
    [AddComponentMenu(Framework.EventListeners.IntEventListener, Framework.MenuOrders.Int)]
    public class IntEventListener : EventListener<int>
    {
    }
}