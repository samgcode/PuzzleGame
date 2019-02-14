using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Player player;
    public PlayerControler controller;

    public void move() {
        if (player.canMove)
        {
            if (Input.GetKey(KeyCode.LeftShift)) {
                player.speed = 1.2f;
            } else if (player.devMode == true) {
                player.speed = 2;
                player.col.isTrigger = true;
            } else {
                player.col.isTrigger = false;
                player.speed = 0.8f;
            }

            float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * player.speed;
            float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * player.speed;

            Vector2 newPos = new Vector2(player.rb.position.x + x, player.rb.position.y + y);
            player.rb.position = newPos;

            if (Input.anyKey) {
                player.animator.SetBool("isWalking", true);
            } else {
                player.animator.SetBool("isWalking", false);
            }

            if (Input.GetKey(KeyCode.F)) {
                player.maneger.TitleScreen();
            }

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, 45f);
            } else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, -45f);
            } else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, 135f);
            } else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, -135f);
            } else if (Input.GetKey(KeyCode.UpArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            } else if (Input.GetKey(KeyCode.DownArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, 180f);
            } else if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, 90f);
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                transform.eulerAngles = new Vector3(0f, 0f, -90f);
            }
        }
        else
        {
            player.animator.SetBool("isWalking", false);
            if (Input.GetKey(KeyCode.Escape))
            {
                player.inWireMenu = false;
            }
        }
    }
}
