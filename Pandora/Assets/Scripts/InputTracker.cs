using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTracker : MonoBehaviour 
{
    private bool interactPressed = false;
    private static InputTracker instance;

    void InteractButtonPressed() 
    {
        if (Input.GetKeyDown("i")) {
            interactPressed = true;
        }
    }
    public static InputTracker GetInstance() 
    {
        return instance;
    }
    void Update() {
        InteractButtonPressed();
    }

    public bool GetInteractButtonPressed()
    {
        bool result = interactPressed;
        interactPressed = false;
        return result;
    }
}