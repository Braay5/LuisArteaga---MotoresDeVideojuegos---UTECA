using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidPlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private float bounds = 6.6f;

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + moveInput * moveSpeed * Time.deltaTime, -bounds, bounds);
        transform.position = playerPosition;
    }
}
