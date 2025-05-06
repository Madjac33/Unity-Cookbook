using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5.0f;
    public InputAction playerControls;

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable() {
        playerControls.Enable();
    }

    private void OnDisable() {
        playerControls.Disable();
    }

    private void Update() {
        moveDirection = playerControls.ReadValue<Vector2>();
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(moveDirection.x * speed * Time.deltaTime, moveDirection.y * speed * Time.deltaTime);
    }
}
