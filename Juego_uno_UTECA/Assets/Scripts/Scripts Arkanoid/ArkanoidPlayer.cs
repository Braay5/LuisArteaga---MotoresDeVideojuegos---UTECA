using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidPlayer : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveInput * moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
