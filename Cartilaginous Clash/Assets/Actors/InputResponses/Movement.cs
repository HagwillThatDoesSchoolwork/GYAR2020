using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private float maxSpeed = 1, accelerationForce = 1, activeDrag = 1, inactiveDrag = 5;

    private Vector2 movementInput;

    private float movementForce, maxSpeedForce;
    bool willExceedMaxSpeed;

    private void Awake() => rb = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        movementForce = accelerationForce * activeDrag + (activeDrag * activeDrag * Time.fixedDeltaTime);
        willExceedMaxSpeed = movementForce * Time.fixedDeltaTime + rb.velocity.magnitude >= maxSpeed;

        if (movementInput.sqrMagnitude > 0 && !willExceedMaxSpeed) // If movement input is recieved and the player will not exceed the set max speed proceed to apply the standard amount of force
            rb.AddForce(movementInput * movementForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        else if (movementInput.sqrMagnitude > 0) // If movement input is recived and the player will exceed max speed then dampen the force to get the player as close to the max speed as possible without overstepping the threshold
        {
            maxSpeedForce = maxSpeed * activeDrag + (activeDrag * activeDrag * Time.fixedDeltaTime);
            rb.AddForce(movementInput * maxSpeedForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        if (movementInput.sqrMagnitude > 0) // If input is recieved then set the drag to active drag
            rb.drag = activeDrag;
        else rb.drag = inactiveDrag;

        #region DEBUG
        // If player is flung to hell at way to high speed, make sure that
        // 1. The mass is above or equal to 1

        if (rb.velocity.magnitude > maxSpeed)
            print(gameObject + " broke their max speed of " + maxSpeed + " by " + (rb.velocity.magnitude - maxSpeed) + " um/s!");
        #endregion
    }

    public void Move(InputAction.CallbackContext context) => movementInput = context.ReadValue<Vector2>();
}
