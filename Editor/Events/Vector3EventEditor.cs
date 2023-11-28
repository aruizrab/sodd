using SODD.Events;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Events
{
    [CustomEditor(typeof(Vector3Event))]
    public class Vector3EventEditor : UnityEditor.Editor
    {
        private Vector3 _payload;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            _payload = EditorGUILayout.Vector3Field("Payload", _payload);
            if (GUILayout.Button("Invoke")) (target as Vector3Event)?.Invoke(_payload);
        }
    }
}