using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour {
    GameObject[] toEnable, toDisable;
    public GameObject correct, tryagain;
    int currentSceneIndex;
    
    void Start() {

        currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;

        toEnable = GameObject.FindGameObjectsWithTag ("ToEnable");
        toDisable = GameObject.FindGameObjectsWithTag ("ToDisable");

        foreach (GameObject element in toEnable)
        {
            element.gameObject.SetActive (false);
        }

        foreach (GameObject element in toDisable)
        {
            element.gameObject.SetActive(true);
        }

    }

    public void RightAnswer()
    {
        foreach (GameObject element in toDisable)
        {
            element.gameObject.SetActive(false);
        }
        correct.gameObject.SetActive (true);
        Invoke ("LoadNextLevel", 1f);

    }
    public void WrongAnswer()
    {
        tryagain.SetActive (true);

    }
    void LoadNextLevel()
    {
        SceneManager.LoadScene (currentSceneIndex +1);
    }
    void GotoMainMenu()
    {
        SceneManager.LoadScene ("menu");
    }

}


