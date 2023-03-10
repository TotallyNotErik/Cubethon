using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        if (!GameHasEnded)
        {
            GameHasEnded = true;
            CompleteLevelUI.SetActive(true);
        }
    }

    public void EndGame ()
    {
        if(!GameHasEnded)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
