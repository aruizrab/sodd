using System;
using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     Represents a base event class for all scriptable object events.
    /// </summary>
    /// <typeparam name="T">The type of the event payload.</typeparam>
    /// <remarks>
    ///     This abstract class serves as the base for all specific event types. It implements the
    ///     IEvent interface, allowing listeners to subscribe to or unsubscribe from events, and
    ///     providing a method to invoke the event with a specific payload.
    /// </remarks>
    public abstract class Event<T> : ScriptableObject, IEvent<T>
    {
        /// <inheritdoc />
        public void AddListener(Action<T> listener)
        {
            Listeners += listener;
        }

        /// <inheritdoc />
        public void RemoveListener(Action<T> listener)
        {
            Listeners -= listener;
        }

        /// <inheritdoc />
        public void Invoke(T payload)
        {
            Listeners?.Invoke(payload);
        }

        private event Action<T> Listeners;
    }
}