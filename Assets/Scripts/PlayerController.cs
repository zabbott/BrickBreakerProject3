using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput MyPlayerInput;
    public InputAction JumpAction;
    public InputAction MoveAction;
    public Rigidbody2D RB;
    public bool ShouldBeMoving;
    public float Speed; 
    // Start is called before the first frame update
    void Start()
    {
        MyPlayerInput = GetComponent<PlayerInput>();
        MyPlayerInput.currentActionMap.Enable();
        JumpAction = MyPlayerInput.currentActionMap.FindAction("Jump");
        MoveAction = MyPlayerInput.currentActionMap.FindAction("Move");
        JumpAction.started += Handle_JumpActionStarted;
        MoveAction.started += Handle_MoveActionStarted;
        MoveAction.canceled += Handle_MoveActionCanceled;

        RB = GetComponent<Rigidbody2D>();

    }

    private void Handle_MoveActionCanceled(InputAction.CallbackContext obj)
    {
        ShouldBeMoving = false; 
    }

    private void Handle_MoveActionStarted(InputAction.CallbackContext obj)
    {
        ShouldBeMoving = true; 
    }
    private void FixedUpdate()
    {
        if (ShouldBeMoving)
        {
            float direction = MoveAction.ReadValue<float>();
            RB.velocity = new Vector2(direction * Speed, 0);
        }
        else
        {
            RB.velocity = Vector2.zero;

        }
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
