using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene_R : MonoBehaviour
{
    public void ChangeFromResult()
    {
        if (this.name == "RetryButton")
        {
            Debug.Log("Retry");
            // SceneManager.LoadScene("");
        }
        else if (this.name == "QuitButton")
        {
            Debug.Log("Quit");
            // SceneManager.LoadScene("");
        }
    }
}
