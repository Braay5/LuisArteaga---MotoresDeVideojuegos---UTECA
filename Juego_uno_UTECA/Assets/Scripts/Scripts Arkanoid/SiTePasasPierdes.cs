using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiTePasasPierdes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManagerArkanoid.Instance.ReloadScene();
    }
}
