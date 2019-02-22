using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegment : MonoBehaviour {
    // ∞ ∞ ∞ ∞ ∞ ∞ ∞ ∞ ∞ ∞ ∞ ∞ 8
    public GameObject manager;
    public Player player;

    public int level_;

	void Update () {
        //temp
        if(Input.GetKey(KeyCode.Tab)) {
            SceneManager.LoadScene(5);
        }

        //

        DontDestroyOnLoad(manager);
        player = FindObjectOfType<Player>();
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
            SceneManager.LoadScene(level_ + 5);
        } else {
            SceneManager.LoadScene(0);
        }
        level_ += 1;
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Credits() {
        SceneManager.LoadScene(2);
    }

    public void TitleScreen() {
        SceneManager.LoadScene(0);
    }

    public void ChangeLog() {
        SceneManager.LoadScene(3);
    }
}
