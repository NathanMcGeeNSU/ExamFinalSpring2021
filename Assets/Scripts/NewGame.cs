using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("2Game");
    }

    public void QuitGame ()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
