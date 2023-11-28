using UnityEngine;

namespace SODD.Listeners
{
    /// <summary>
    ///     A MonoBehaviour that listens to events of type float and responds to them.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The FloatEventListener class is a specialized event listener for floating-point number-based events.
    ///         It inherits from the generic EventListener class, providing functionality
    ///         specific to float events.
    ///     </para>
    ///     <para>
    ///         This component can be attached to any GameObject in a Unity scene. Configure the
    ///         target event and response in the Unity Editor. When the target event is invoked,
    ///         this listener will execute the configured actions.
    ///     </para>
    ///     <para>
    ///         It is particularly useful for responding to events that carry floating-point data,
    ///         such as gradual changes in values, smooth transitions, adjustments to game settings,
    ///         or other scenarios where a precise numeric value is required.
    ///     </para>
    /// </remarks>
    [AddComponentMenu(Framework.EventListeners.FloatEventListener, Framework.MenuOrders.Float)]
    public class FloatEventListener : EventListener<float>
    {
    }
}