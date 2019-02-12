using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

    public PlayerControler player;
    public GameObject[] canvasText;

	void Update() {
        if(player.level == 0) 
        {
            int room = player.room;
            foreach(var text in canvasText) 
            {
                setAllInactive();
                switch (room) 
                {
                    case 1:
                        canvasText[0].SetActive(true);
                        canvasText[1].SetActive(true);
                        break;
                    case 2:
                        canvasText[2].SetActive(true);
                        break;
                    case 3:
                        canvasText[3].SetActive(true);
                        canvasText[4].SetActive(true);
                        break;
                    case 4:
                        canvasText[5].SetActive(true);
                        break;
                    default:
                        setAllInactive();
                        break;
                }
            }
        }
	}
    private void setAllInactive() {
        foreach(var text in canvasText) {
            text.SetActive(false);
        }
    }
}
