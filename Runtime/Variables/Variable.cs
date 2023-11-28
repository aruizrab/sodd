using System;
using UnityEngine;

namespace SODD.Variables
{
    /// <summary>
    ///     A generic ScriptableObject that represents a variable of type T.
    /// </summary>
    /// <typeparam name="T">The type of the variable.</typeparam>
    /// <remarks>
    ///     <para>
    ///         The Variable class serves as a base for creating various typed variables as ScriptableObjects.
    ///         It allows for storing and manipulating a value of type T, making it useful for a wide range
    ///         of applications, such as game settings, runtime configurations, or shared data across different
    ///         game components.
    ///     </para>
    ///     <para>
    ///         The value of the variable can be marked as read-only to prevent modification at runtime.
    ///         Additionally, the class provides an event, OnValueChanged, which is invoked whenever
    ///         the value of the variable is changed, allowing for reactive programming patterns.
    ///     </para>
    /// </remarks>
    public abstract class Variable<T> : ScriptableObject, IVariable, IVariable<T>
    {
        [SerializeField] private T value;

        [SerializeField]
        [Tooltip("Prevent the value of this variable from being modified at runtime by other scripts.")]
        private bool readOnly;

        object IVariable.Value
        {
            get => Value;
            set => Value = (T)value;
        }

        /// <summary>
        ///     Gets or sets the value of the variable.
        /// </summary>
        /// <value>The current value of the variable.</value>
        public T Value
        {
            get => value;
            set
            {
                if (readOnly) return;
                if (this.value != null && this.value.Equals(value)) return;
                this.value = value;
                OnValueChanged?.Invoke(value);
            }
        }

        /// <summary>
        ///     Invoked when the value of the variable changes.
        /// </summary>
        public event Action<T> OnValueChanged;
    }
}