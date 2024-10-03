using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }
    private PlayerInputAction playerInputAction;

    public event EventHandler OnPlayerAtack;
    private void Awake(){
        Instance = this;

        playerInputAction = new PlayerInputAction();
        playerInputAction.Enable();
        playerInputAction.Combat.Atack.started += PlayerAtack_started;
    }

    public void PlayerAtack_started(InputAction.CallbackContext obj) {
           
            OnPlayerAtack?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovmentVector(){
        Vector2 inputVector = playerInputAction.Player.Move.ReadValue<Vector2>();
        return inputVector;
    }


    public Vector3 GetMousePosition(){
        Vector3 mousePos = Mouse.current.position.ReadValue();
        return mousePos;
    }
}
