using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WireUI : MonoBehaviour {

    public GameObject wireUI;
    public Sprite connectedSprite;
    public Player player;
    public Wire[] wires;
    public SpriteRenderer renderer_;
    public Image image;
    public bool allConnected;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        if(player.inWireMenu) {
            wireUI.SetActive(true);
            //temp\/
            if(Input.GetKey(KeyCode.W)) {
                foreach(Wire wire in wires) {
                    wire.show();
                    wire.isConnected = true;
                }
                image.sprite = connectedSprite;
                renderer_.sprite = connectedSprite;
                allConnected = true;
            }
            //temp/\
        } else {
            wireUI.SetActive(false);
        }
	}
}
