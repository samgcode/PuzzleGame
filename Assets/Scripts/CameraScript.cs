using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript: MonoBehaviour {

    [Header("Reference Size")]
    public float width;        // Width of the game in units
    public float height;   // Width of the game in units

    public float pixelsPerUnit;        // PPU

    [Header(" ")]
    public bool detectFullscreenMode = false;    // Should the script re-trigger when the game is sent into fullscreen mode? (ie: in WebGL browser)

    private bool lastFullscreenState = false;

	private void Start()
	{
        Debug.Log(Screen.width + " , " + Screen.height);
        width = Screen.width;
        height = Screen.height;
	}

	void Awake()
    {
        SetSizer();
    }

    void SetSizer()
    {
        float aspectRatio = (float)Screen.width / (float)Screen.height;
        float newCameraHeight = (width / pixelsPerUnit) / aspectRatio;
        float targetAspectRatio = width / height;

        if (aspectRatio < targetAspectRatio)
            GetComponent<Camera>().orthographicSize = newCameraHeight / 2f;

        lastFullscreenState = Screen.fullScreen;
    }


    void Update()
    {
        if (detectFullscreenMode)
        {
            if (Screen.fullScreen != lastFullscreenState)
                SetSizer();
        }
    }

    public void MoveCamera(string direction)
    {
        if (direction == "LEFT")
        {
            transform.position = new Vector3(transform.position.x - 3.2f, transform.position.y, transform.position.z);
        }
        else if (direction == "RIGHT")
        {
            transform.position = new Vector3(transform.position.x + 3.2f, transform.position.y, transform.position.z);
        }
        else if (direction == "UP")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.94f, transform.position.z);
        }
        else if (direction == "DOWN")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.94f, transform.position.z);
        }
    }

}
