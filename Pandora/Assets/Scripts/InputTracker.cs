using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTracker : MonoBehaviour 
{
    public bool interactPressed = false;
    private static InputTracker instance;

    void InteractButtonPressed() 
    {
        if (Input.GetKeyDown("i")) {
            interactPressed = true;
            Debug.Log("i/interact key was pressed");
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