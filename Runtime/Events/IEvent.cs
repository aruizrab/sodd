using System;

namespace SODD.Events
{
    /// <summary>
    ///     Represents a generic event.
    /// </summary>
    /// <typeparam name="T">The type of the event payload.</typeparam>
    /// <remarks>
    ///     Use IEvent to create events that can notify registered listeners
    ///     with a payload of type T. It provides methods to add or remove listeners
    ///     and to invoke the event.
    /// </remarks>
    public interface IEvent<T>
    {
        /// <summary>
        ///     Registers a listener to the event.
        /// </summary>
        /// <param name="listener">The listener to register.</param>
        /// <remarks>
        ///     Adds a new listener to the event. The listener is an action that takes
        ///     a parameter of type T.
        /// </remarks>
        void AddListener(Action<T> listener);

        /// <summary>
        ///     Unregisters a listener from the event.
        /// </summary>
        /// <param name="listener">The listener to unregister.</param>
        /// <remarks>
        ///     Removes a previously registered listener from the event.
        /// </remarks>
        void RemoveListener(Action<T> listener);

        /// <summary>
        ///     Invokes the event, notifying all registered listeners.
        /// </summary>
        /// <param name="payload">The event payload to pass to the listeners.</param>
        /// <remarks>
        ///     Calls each registered listener's action, providing them with the payload.
        /// </remarks>
        void Invoke(T payload);
    }
}