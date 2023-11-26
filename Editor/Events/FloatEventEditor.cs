using SODD.Events;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Events
{
    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : UnityEditor.Editor
    {
        private float _payload;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            _payload = EditorGUILayout.FloatField("Payload", _payload);
            if (GUILayout.Button("Invoke")) (target as FloatEvent)?.Invoke(_payload);
        }
    }
}