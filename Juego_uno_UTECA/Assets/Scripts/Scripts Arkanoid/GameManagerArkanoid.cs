using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerArkanoid : MonoBehaviour
{

    private int blocksLeft;
    public static GameManagerArkanoid Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Bloque").Length;
    }

    public void BlockDestroyed()
    {
        blocksLeft--;
        if(blocksLeft <= 0)
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
 