using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegment : MonoBehaviour {

    public GameObject sceneManeger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DontDestroyOnLoad(sceneManeger);
	}

    public void startGame() {
        SceneManager.LoadScene(1);
    }

    public void finishLevel() {
        SceneManager.LoadScene(0);
    }
}
