using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem

public class LaunchBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame.
    void Update()
    {
        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue()
        Debug.Log(touchPosition)
    }
}
