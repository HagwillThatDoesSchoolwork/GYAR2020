using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Health : MonoBehaviour
{
    private bool died = false;

    private GameObject deathTrigger;

    public int health = 100;
    public int MaxHealth { get; private set; }

    public bool isPlayer = false;

    [Space]
    [SerializeField]
    private float fadeDistance = 10;
    [SerializeField]
    private float fadeOffset = 1.5f;

    [SerializeField]
    private Color fadeColour = Color.blue;

    [SerializeField]
    private LayerMask terrainLayerMask;

    public event Action DeathEvent;

    private List<GameObject> players = new List<GameObject>();
    private List<GameObject> availableSpawnPoints = new List<GameObject>();
    private List<GameObject> spawnPoints = new List<GameObject>();

    private void Awake() => deathTrigger = GameObject.FindGameObjectWithTag("DeathTrigger");

    private void Start()
    {
        MaxHealth = health;

        GameObject masterSpawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        for (int i = 0; i < masterSpawnPoint.transform.childCount; i++)
            spawnPoints.Add(masterSpawnPoint.transform.GetChild(i).gameObject);

        players.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        players.Remove(gameObject);
    }

    private void Update()
    {
        if (health <= 0 && isPlayer && !died)
            DeathEvent?.Invoke();

        if (health <= 0 && !died)
        {
            died = true;
            Die();
        }
        else if (died && deathTrigger.transform.position.z - transform.position.z <= fadeDistance)
            StartCoroutine(FadeOut());
    }

    private void Die()
    {
        PlayerInput playerInput = GetComponent<PlayerInput>();
        if (playerInput != null && !playerInput.Equals(null))
            playerInput.enabled = false;

        //if (transform.parent != null && !transform.parent.Equals(null))
        //    transform.parent = null;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null && !rb.Equals(null))
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.useGravity = true;
        }
    }

    private IEnumerator FadeOut()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Color startColour = renderer.color;
        float distanceToKillTrigger = fadeDistance;

        while (distanceToKillTrigger <= fadeDistance)
        {
            distanceToKillTrigger = (deathTrigger.transform.position.z - fadeOffset) - transform.position.z;
            renderer.color = Color.Lerp(startColour, fadeColour, 1 - (distanceToKillTrigger / fadeDistance));
            yield return null;
        }
    }

    public void RespawnPlayer()
    {
        foreach (GameObject player in players)
        {
            foreach (GameObject spawnPoint in spawnPoints)
            {
                Physics.Raycast(player.transform.position, spawnPoint.transform.position - player.transform.position, out RaycastHit hit, Vector3.Distance(player.transform.position, spawnPoint.transform.position), terrainLayerMask);
                if (hit.collider == null && hit.collider.Equals(null))
                    availableSpawnPoints.Add(spawnPoint);
            }
        }

        Vector3 respawnPosition = availableSpawnPoints[UnityEngine.Random.Range(0, availableSpawnPoints.Count)].transform.position;
        transform.position = respawnPosition;

        Rigidbody rb = transform.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;

        transform.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        transform.GetComponent<PlayerInput>().enabled = true;

        health = MaxHealth;
        died = false;

        availableSpawnPoints.Clear();
    }
}
