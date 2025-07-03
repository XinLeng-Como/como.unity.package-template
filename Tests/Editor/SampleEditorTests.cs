using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using COMO.PackageTemplate;
using COMO.PackageTemplate.Editor;

namespace COMO.PackageTemplate.Tests.Editor
{
    /// <summary>
    /// Sample editor tests for the package template
    /// Replace with your actual editor test cases
    /// </summary>
    public class SampleEditorTests
    {
        [Test]
        public void SampleEditor_Creation_IsSuccessful()
        {
            // Arrange
            GameObject testObject = new GameObject("TestObject");
            SampleScript sampleScript = testObject.AddComponent<SampleScript>();
            
            // Act
            var editor = UnityEditor.Editor.CreateEditor(sampleScript);
            
            // Assert
            Assert.IsNotNull(editor);
            Assert.IsInstanceOf<SampleEditor>(editor);
            
            // Cleanup
            Object.DestroyImmediate(editor);
            Object.DestroyImmediate(testObject);
        }
        
        [Test]
        public void SampleScript_ComponentProperties_AreValid()
        {
            // Arrange
            GameObject testObject = new GameObject("TestObject");
            SampleScript sampleScript = testObject.AddComponent<SampleScript>();
            
            // Act & Assert
            Assert.IsNotNull(sampleScript);
            Assert.IsTrue(testObject.GetComponent<SampleScript>() != null);
            
            // Cleanup
            Object.DestroyImmediate(testObject);
        }
    }
}
