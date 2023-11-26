using NUnit.Framework;
using SODD.Events;
using UnityEngine;

namespace SODD.Editor.Tests.Events
{
    public class IntEventTests
    {
        private int _receivedValue;
        private bool _wasCalled;

        [SetUp]
        public void SetUp()
        {
            _receivedValue = 0;
            _wasCalled = false;
        }

        private void Listener(int value)
        {
            _receivedValue = value;
            _wasCalled = true;
        }

        [Test]
        public void IntEvent_InvokesListenerWithCorrectValue()
        {
            // Arrange
            var intEvent = ScriptableObject.CreateInstance<IntEvent>();
            var expectedValue = 10;

            intEvent.AddListener(Listener);

            // Act
            intEvent.Invoke(expectedValue);

            // Assert
            Assert.IsTrue(_wasCalled, "Listener was not called.");
            Assert.AreEqual(expectedValue, _receivedValue, "Listener did not receive the correct value.");

            // Cleanup
            Object.DestroyImmediate(intEvent);
        }

        [Test]
        public void IntEvent_RemoveListener_StopsReceivingEvents()
        {
            // Arrange
            var intEvent = ScriptableObject.CreateInstance<IntEvent>();
            intEvent.AddListener(Listener);

            // Act
            intEvent.RemoveListener(Listener);
            intEvent.Invoke(10);

            // Assert
            Assert.IsFalse(_wasCalled, "Listener was called after being removed.");

            // Cleanup
            Object.DestroyImmediate(intEvent);
        }
    }
}