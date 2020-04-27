using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstFire : ShootingBase
{
    [SerializeField]
    private int nrOfPellets = 12;
    [SerializeField]
    private float pelletSpread = 30, perPelletKnockback = 0.5f;
    [SerializeField]
    [Tooltip("The time it takes to reload in seconds")]
    private float reloadTime = 2;
    [SerializeField]
    private int pelletSpawnIntervalFrames = 1;

    private float timeReloaded = 0;
    private bool waitToSpawn = false;

    private void Start() => waitToSpawn = pelletSpawnIntervalFrames > 0;

    private void Update()
    {
        if (timeReloaded < reloadTime)
            timeReloaded += Time.deltaTime;
        else if (timeReloaded >= reloadTime)
            reloaded = true;

        if (FireInput && reloaded)
        {
            reloaded = false;
            StartCoroutine(Fire());
            timeReloaded = 0;
        }
    }

    private IEnumerator Fire()
    {
        for (int i = 0; i < nrOfPellets; i++)
        {
            float randomDir = Random.Range(-pelletSpread / 2, pelletSpread / 2);
            Instantiate(round, firePoint.transform.position, Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + randomDir));
            rb.AddForce(-transform.up * perPelletKnockback, ForceMode.Impulse);

            if (waitToSpawn)
            {
                for (int j = 0; j < pelletSpawnIntervalFrames; j++)
                    yield return new WaitForEndOfFrame();
            }
        }
    }
}
