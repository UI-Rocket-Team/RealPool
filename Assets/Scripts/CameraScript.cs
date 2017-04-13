using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public Camera[] cameras;
    private int currentCameraIndex;
    // Use this for initialization
    void Start () {
        currentCameraIndex = 0;
        cameras[1].gameObject.SetActiveRecursively(false);
        cameras[0].gameObject.SetActiveRecursively(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("here");
            if (currentCameraIndex == 0)
                currentCameraIndex++;
            else
            {
                currentCameraIndex = 0;
            }

            for (int i = 0; i < cameras.Length; i++)
            {
                cameras[i].gameObject.SetActiveRecursively(false);

            }
            cameras[currentCameraIndex].gameObject.SetActive(true);
            

        }

    }
}
