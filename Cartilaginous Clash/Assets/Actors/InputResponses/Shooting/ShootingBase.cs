using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class ShootingBase : MonoBehaviour
{
    protected Rigidbody rb;

    [SerializeField]
    protected GameObject round;
    [SerializeField]
    protected GameObject firePoint;

    protected bool reloaded = true;
    protected bool FireInput { get; private set; }

    protected void Awake() => rb = GetComponent<Rigidbody>();

    public void Fire(InputAction.CallbackContext context) => FireInput = context.performed;
}
