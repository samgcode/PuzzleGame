using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegment : MonoBehaviour {

    public GameObject manager;
    public PlayerControler player;

	void Update () {
        DontDestroyOnLoad(manager);
        player = FindObjectOfType<PlayerControler>();
	}

    public void StartGame() {
        SceneManager.LoadScene(3);
    }

    public void Levels() {
        SceneManager.LoadScene(1);
    }

    public void NextLevel() {
        //SceneManager.LoadScene(player.level);
        SceneManager.LoadScene(0);
        player.level += 1;
    }

    public void FailLevel() {
        Debug.Log("AHHHHHHH");
    }

    public void Credits() {
        SceneManager.LoadScene(2);
    }

    public void TitleScreen() {
        SceneManager.LoadScene(0);
    }
}
