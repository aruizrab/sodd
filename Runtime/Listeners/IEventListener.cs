using SODD.Events;

namespace SODD.Listeners
{
    /// <summary>
    ///     Defines a listener interface for handling events of a specific type.
    /// </summary>
    /// <typeparam name="T">The type of the event payload.</typeparam>
    /// <remarks>
    ///     Implement this interface in classes that need to listen to specific events
    ///     within the game. The interface provides methods to start and stop listening
    ///     to events, as well as a method to handle the event when it is invoked.
    /// </remarks>
    public interface IEventListener<T>
    {
        /// <summary>
        ///     Subscribes to the event to start receiving notifications.
        /// </summary>
        /// <param name="event">The event to start listening to.</param>
        /// <remarks>
        ///     Adds the OnEventInvoked method as a listener to the specified event.
        /// </remarks>
        void StartListening(IEvent<T> @event)
        {
            @event?.AddListener(OnEventInvoked);
        }

        /// <summary>
        ///     Unsubscribes from the event to stop receiving notifications.
        /// </summary>
        /// <param name="event">The event to stop listening to.</param>
        /// <remarks>
        ///     Removes the OnEventInvoked method as a listener from the specified event.
        /// </remarks>
        void StopListening(IEvent<T> @event)
        {
            @event?.RemoveListener(OnEventInvoked);
        }

        /// <summary>
        ///     Called when the event is invoked.
        /// </summary>
        /// <param name="payload">The event payload.</param>
        /// <remarks>
        ///     Implement this method to define the action to be taken when the event is triggered.
        ///     The payload of the event is passed as a parameter.
        /// </remarks>
        void OnEventInvoked(T payload);
    }
}