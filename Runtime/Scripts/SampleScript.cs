using UnityEngine;

namespace COMO.PackageTemplate
{
    /// <summary>
    /// Sample script demonstrating Unity package template structure
    /// Replace this with your actual package functionality
    /// </summary>
    public class SampleScript : MonoBehaviour
    {
        [SerializeField] private string packageName = "COMO Unity Package Template";
        
        private void Start()
        {
            Debug.Log($"Hello from {packageName}!");
        }
        
        /// <summary>
        /// Sample method for demonstration purposes
        /// </summary>
        /// <param name="message">Message to log</param>
        public void LogMessage(string message)
        {
            Debug.Log($"[{packageName}] {message}");
        }
    }
}
