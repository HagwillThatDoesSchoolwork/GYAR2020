using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed, moveSpeedMultMin, moveSpeedMultMax;
    private float moveSpeedMultiplier;

    private void Start()
    {
        moveSpeedMultiplier = Random.Range(moveSpeedMultMin, moveSpeedMultMax);
        Destroy(gameObject, 10);
    }
    void Update()
    {
        transform.position += transform.up * moveSpeed * moveSpeedMultiplier * Time.deltaTime;
        Debug.DrawRay(transform.position, transform.up, Color.green);
    }
}
