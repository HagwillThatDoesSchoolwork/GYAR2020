using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Aiming : MonoBehaviour
{
    [SerializeField]
    private float aimingSpeed = 36, aimOverStepThreshold = 0.25f;

    private Vector2 aimDirection = Vector3.zero;
    private float aimAnglePsuedo = 0;
    public bool rotatedLastFrame = false;
    private float lastAngle = 0f;

    private void FixedUpdate()
    {
        Vector2 normalizedAimDirection = aimDirection.normalized;

        if (aimDirection.sqrMagnitude > 0)
        {
            float aimAngleActual = Mathf.Atan2(normalizedAimDirection.y, normalizedAimDirection.x) * Mathf.Rad2Deg;
            if (Vector2.Dot(transform.up, normalizedAimDirection) > -1 + aimOverStepThreshold || !rotatedLastFrame) // If the players aims less than 180 +- aimOverStepThreshold from the characters direction or it did not change it's direction from last frame then use the unedited input, otherwise use the last input given
                aimAnglePsuedo = aimAngleActual;

            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, aimAnglePsuedo - 90), aimingSpeed * Time.fixedDeltaTime); // Rotate towards aimAnglePsuedo by the aimingSpeed

            if (transform.rotation.z != lastAngle) // If there is any aiming input and the direcetion is unchanged from last frame rotatedLastFram is set to true, otherwise false
                rotatedLastFrame = true;
            else
                rotatedLastFrame = false;
        }


        lastAngle = transform.rotation.z;
    }

    public void Aim(InputAction.CallbackContext context) => aimDirection = context.ReadValue<Vector2>();
}
