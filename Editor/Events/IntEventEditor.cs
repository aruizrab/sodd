using SODD.Events;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Events
{
    [CustomEditor(typeof(IntEvent))]
    public class IntEventEditor : UnityEditor.Editor
    {
        private int _payload;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            _payload = EditorGUILayout.IntField("Payload", _payload);
            if (GUILayout.Button("Invoke")) (target as IntEvent)?.Invoke(_payload);
        }
    }
}