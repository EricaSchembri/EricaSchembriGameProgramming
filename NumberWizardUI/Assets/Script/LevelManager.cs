using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelName)
    {
        print("Loading Level " + levelName);

        //loads the Scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
