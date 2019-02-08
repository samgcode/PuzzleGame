using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegment : MonoBehaviour {

    public GameObject manager;
    public PlayerControler player;

    public int level_;

	void Update () {
        DontDestroyOnLoad(manager);
        player = FindObjectOfType<PlayerControler>();
	}

    public void StartGame() {
        level_ = 0;
        SceneManager.LoadScene(3);
    }

    public void Levels() {
        SceneManager.LoadScene(1);
    }

    public void NextLevel() {
        if(level_ < 1) {
            SceneManager.LoadScene(level_ + 4);
        } else {
            SceneManager.LoadScene(0);
        }
        level_ += 1;
    }

    public void Restart() {
        Debug.Log("AHHHHHHH");
    }

    public void Credits() {
        SceneManager.LoadScene(2);
    }

    public void TitleScreen() {
        SceneManager.LoadScene(0);
    }
}
