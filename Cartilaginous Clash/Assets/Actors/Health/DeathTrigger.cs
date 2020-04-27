using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        Health colliderHealth = collider.GetComponent<Health>();
        if (colliderHealth != null && !colliderHealth.Equals(null) && colliderHealth.isPlayer)
            colliderHealth.RespawnPlayer();
    }
}
