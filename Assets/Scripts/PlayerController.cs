using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput MyPlayerInput;
    public InputAction JumpAction;
    // Start is called before the first frame update
    void Start()
    {
        MyPlayerInput = GetComponent<PlayerInput>();
        MyPlayerInput.currentActionMap.Enable();
        JumpAction = MyPlayerInput.currentActionMap.FindAction("Jump");
        JumpAction.started += Handle_JumpActionStarted; 
    }

    private void Handle_JumpActionStarted(InputAction.CallbackContext obj)
    {
        print("Hey i saw spacebar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
