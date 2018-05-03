using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager> {
    [SerializeField]
    private MainPlane mainPlane;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            mainPlane.FireOnce();
        }
        else if (Input.GetKey(KeyCode.J))
        {
            mainPlane.FireStart();
        }
    }
}
