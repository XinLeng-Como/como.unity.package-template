using UnityEngine;
using UnityEditor;

namespace COMO.PackageTemplate.Editor
{
    /// <summary>
    /// Sample editor script for the package template
    /// Replace this with your actual editor functionality
    /// </summary>
    [CustomEditor(typeof(SampleScript))]
    public class SampleEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            
            GUILayout.Space(10);
            
            if (GUILayout.Button("Test Package Template"))
            {
                SampleScript sampleScript = (SampleScript)target;
                sampleScript.LogMessage("Editor button clicked!");
            }
            
            EditorGUILayout.HelpBox("This is a sample editor script for the COMO Unity Package Template. Replace with your actual editor functionality.", MessageType.Info);
        }
    }
}
