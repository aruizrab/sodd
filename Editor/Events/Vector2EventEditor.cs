using SODD.Events;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Events
{
    [CustomEditor(typeof(Vector2Event))]
    public class Vector2EventEditor : UnityEditor.Editor
    {
        private Vector2 _payload;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            _payload = EditorGUILayout.Vector2Field("Payload", _payload);
            if (GUILayout.Button("Invoke")) (target as Vector2Event)?.Invoke(_payload);
        }
    }
}