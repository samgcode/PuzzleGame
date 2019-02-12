using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireUI : MonoBehaviour {

    public GameObject wireUI;
    public PlayerControler player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerControler>();
	}
	
	// Update is called once per frame
	void Update () {
        if(player.inWireMenu) {
            wireUI.SetActive(true);
        } else {
            wireUI.SetActive(false);
        }
	}
}
