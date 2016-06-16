using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Platform;

public class GameControl : MonoBehaviour
{
    [SerializeField]    private Score       score;

    void Update()
    {
        switch (PlatformDetector.inputState)
        {
            case PlatformDetector.InputState.Nothing:
                break;
            case PlatformDetector.InputState.Windows:
                windowsInput();
                break;
            case PlatformDetector.InputState.Android:
                androidInput();
                break;
        }
    }

    // Detecting input for the Windows platform
    private void windowsInput()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hitInfo;
            Ray castRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(castRay, out hitInfo))
            {
                Destroy(hitInfo.collider.gameObject);
                score.scoreCount++;
            }
        }
    }

    // Detecting input for the Android platform
    private void androidInput()
    {
        foreach (Touch touch in Input.touches)
        {
            RaycastHit hitInfo;
            Ray castRay = Camera.main.ScreenPointToRay(touch.position);

            if (Physics.Raycast(castRay, out hitInfo))
            {
                Destroy(hitInfo.collider.gameObject);
                score.scoreCount++;
            }
        }
    }
}
