using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Restart()
    {
        Accelerometer.Instance = null;
        SceneManager.LoadScene(0);
    }
    
}
