using SODD.Events;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Events
{
    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : UnityEditor.Editor
    {
        private bool _payload;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            _payload = EditorGUILayout.Toggle("Payload", _payload);
            if (GUILayout.Button("Invoke")) (target as BoolEvent)?.Invoke(_payload);
        }
    }
}