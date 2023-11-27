using SODD.Events;
using UnityEngine;
using UnityEngine.Events;

namespace SODD.Listeners
{
    /// <summary>
    ///     Abstract MonoBehaviour class that listens to events of a specific type and triggers UnityEvents in response.
    /// </summary>
    /// <typeparam name="T">The type of the event payload.</typeparam>
    /// <remarks>
    ///     <para>
    ///         This class should be inherited by concrete listener classes that need to respond to specific events in Unity.
    ///         It provides functionality to automatically start and stop listening to events based on the MonoBehaviour's
    ///         enabled state.
    ///     </para>
    ///     <para>
    ///         Assign the target event in the Unity Editor and define the response in the onEventInvoked UnityEvent.
    ///     </para>
    /// </remarks>
    public abstract class EventListener<T> : MonoBehaviour, IEventListener<T>
    {
        [SerializeField] private Event<T> targetEvent;
        [SerializeField] private UnityEvent<T> onEventInvoked;

        /// <summary>
        ///     Automatically starts listening to the event when the GameObject is enabled.
        /// </summary>
        private void OnEnable()
        {
            StartListening(targetEvent);
        }

        /// <summary>
        ///     Automatically stops listening to the event when the GameObject is disabled.
        /// </summary>
        private void OnDisable()
        {
            StopListening(targetEvent);
        }

        /// <summary>
        ///     Subscribes to the target event.
        /// </summary>
        /// <param name="event">The event to start listening to.</param>
        public void StartListening(IEvent<T> @event)
        {
            @event?.AddListener(OnEventInvoked);
        }

        /// <summary>
        ///     Unsubscribes from the target event.
        /// </summary>
        /// <param name="event">The event to stop listening to.</param>
        public void StopListening(IEvent<T> @event)
        {
            @event?.RemoveListener(OnEventInvoked);
        }

        /// <summary>
        ///     Called when the event is invoked, triggering the assigned UnityEvent.
        /// </summary>
        /// <param name="payload">The event payload.</param>
        public void OnEventInvoked(T payload)
        {
            onEventInvoked?.Invoke(payload);
        }
    }
}