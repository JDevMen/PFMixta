using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField] Movement movement;

    KeyboardActions controls;
    KeyboardActions.PlayerActions playerMovement;

    Vector2 horizontalInput;

    private void Awake()
    {
        controls = new KeyboardActions();
        playerMovement = controls.Player;

        playerMovement.Move.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {

        movement.ReceiveInput(horizontalInput);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }
}
