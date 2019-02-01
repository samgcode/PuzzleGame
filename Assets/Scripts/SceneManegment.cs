using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegment : MonoBehaviour {

    public GameObject sceneManeger;
    public PlayerControler player;

	void Update () {
        DontDestroyOnLoad(sceneManeger);
	}

    public void startGame() {
        SceneManager.LoadScene(1);
    }

    public void NextLevel() {
        SceneManager.LoadScene(0);
        player.level += 1;
    }

    public void FailLevel() {
            
    }
}
