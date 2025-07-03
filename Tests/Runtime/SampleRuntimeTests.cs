using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using COMO.PackageTemplate;

namespace COMO.PackageTemplate.Tests
{
    /// <summary>
    /// Sample runtime tests for the package template
    /// Replace with your actual test cases
    /// </summary>
    public class SampleRuntimeTests
    {
        [Test]
        public void SampleScript_Creation_IsSuccessful()
        {
            // Arrange
            GameObject testObject = new GameObject("TestObject");
            
            // Act
            SampleScript sampleScript = testObject.AddComponent<SampleScript>();
            
            // Assert
            Assert.IsNotNull(sampleScript);
            
            // Cleanup
            Object.DestroyImmediate(testObject);
        }
        
        [UnityTest]
        public IEnumerator SampleScript_LogMessage_WorksCorrectly()
        {
            // Arrange
            GameObject testObject = new GameObject("TestObject");
            SampleScript sampleScript = testObject.AddComponent<SampleScript>();
            
            // Act
            sampleScript.LogMessage("Test message");
            
            // Wait one frame
            yield return null;
            
            // Assert - In a real test, you might capture and verify the log output
            Assert.IsTrue(true); // Placeholder assertion
            
            // Cleanup
            Object.DestroyImmediate(testObject);
        }
    }
}
