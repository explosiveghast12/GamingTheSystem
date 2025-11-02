using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class UserControlsGravity : MonoBehaviour
{
    public InputAction impish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        impish.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.gravity = impish.ReadValue<Vector2>();
    }
}
