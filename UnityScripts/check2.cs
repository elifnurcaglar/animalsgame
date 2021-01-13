using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check2 : MonoBehaviour {

int currentSceneIndex;

void Start() {

    currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
}

    public void RightAnswer()
    {

        Invoke ("LoadNextLevel", 2f);

    }
    
   void LoadNextLevel()
    {
        SceneManager.LoadScene (currentSceneIndex +1);
    }

}


