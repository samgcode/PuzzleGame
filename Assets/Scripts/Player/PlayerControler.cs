using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour {

    public PlayerMovement movement;
    public Player player;

	private void Start()
	{
        player.speed = 0.8f;
        player.maneger = FindObjectOfType<SceneManegment>();
        player.cam = FindObjectOfType<CameraScript>();
	}

	void Update () {
        player.level = player.maneger.level_;

        if(player.inWireMenu) {
            player.canMove = false;
        } else {
            player.canMove = true;
        }

        if (Input.GetKey(KeyCode.R))
        {
            player.maneger.Restart();
        }

        movement.move();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        string tag_ = other.tag;
        string name_ = other.name;

        int roomNum;

        if (int.TryParse(name_, out roomNum)) {
            player.room = roomNum;
            Debug.Log(roomNum);
        }

        switch(tag_) {
            case "RIGHT": 
                player.cam.MoveCamera("RIGHT");
                transform.position = new Vector3(transform.position.x + 0.8f, transform.position.y, transform.position.z);
                break;
            case "LEFT":
                player.cam.MoveCamera("LEFT");
                transform.position = new Vector3(transform.position.x - 0.8f, transform.position.y, transform.position.z);
                break;
            case "UP":
                player.cam.MoveCamera("UP");
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.8f, transform.position.z);
                break;
            case "DOWN":
                player.cam.MoveCamera("DOWN");
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.8f, transform.position.z);
                break;
        }
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
        if(collision.tag == "wire") {
            if(Input.GetKey(KeyCode.Space)) {
                player.inWireMenu = true;
            }
        }

	}
}
