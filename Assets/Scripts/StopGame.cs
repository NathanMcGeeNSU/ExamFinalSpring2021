using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGame : MonoBehaviour
{
    public void GameisStopped()
    {
        SceneManager.LoadScene("3Exit");
    }
}
