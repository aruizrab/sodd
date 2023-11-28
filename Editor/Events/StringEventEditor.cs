using SODD.Events;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Events
{
    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : UnityEditor.Editor
    {
        private string _payload;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            _payload = EditorGUILayout.TextField("Payload", _payload);
            if (GUILayout.Button("Invoke")) (target as StringEvent)?.Invoke(_payload);
        }
    }
}