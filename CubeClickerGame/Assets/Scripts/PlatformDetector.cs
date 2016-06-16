using UnityEngine;
using System.Collections;

namespace Platform
{
    public class PlatformDetector : MonoBehaviour
    {
        public enum     InputState  { Nothing, Windows, Android };
        public static   InputState  inputState;

        void Awake()
        {
            if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                inputState = InputState.Windows;
            }

            else if (Application.platform == RuntimePlatform.Android)
            {
                inputState = InputState.Android;
            }
        }
    }
}
