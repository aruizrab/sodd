using UnityEngine;

namespace SODD.Events
{
    /// <summary>
    ///     A ScriptableObject representing an event that carries a string payload.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The StringEvent class is a concrete implementation of the Event class for string payloads.
    ///         It can be used to create events in the Unity Editor that handle text data, making it suitable for scenarios
    ///         such as displaying messages, updating UI text elements, or triggering text-based actions.
    ///     </para>
    ///     <para>
    ///         This class can be used to create string-based events directly in the Unity Editor.
    ///         Listeners can be registered to these events, which will be invoked with
    ///         a string value, allowing for dynamic and flexible event handling based on textual data.
    ///     </para>
    /// </remarks>
    [CreateAssetMenu(menuName = Framework.Events.String, fileName = nameof(StringEvent),
        order = Framework.MenuOrders.String)]
    public sealed class StringEvent : Event<string>
    {
    }
}