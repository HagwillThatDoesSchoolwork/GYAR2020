using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    private float degPerSec = 1;

    private void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, degPerSec * Time.deltaTime);
    }
}
