using System.IO;
using UnityEditor;
using UnityEngine;

namespace SODD.Editor.Utils
{
    internal static class EditorHelper
    {
        public static void CreateScriptableObject<T>() where T : ScriptableObject
        {
            var asset = ScriptableObject.CreateInstance<T>();
            var path = "Assets";
            
            foreach (var selected in Selection.GetFiltered<Object>(SelectionMode.Assets))
            {
                path = AssetDatabase.GetAssetPath(selected);
                if (File.Exists(path)) path = Path.GetDirectoryName(path);
                break;
            }

            path += $"/{ObjectNames.NicifyVariableName(asset.GetType().Name)}.asset";
            ProjectWindowUtil.CreateAsset(asset, path);
        }
    }
}