using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    Transform MainCamera;
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera").transform;
    }

    void OnMouseDown()
    {
        if (name == "PlayButton")
        {
            MainCamera.transform.position = new Vector3(2500f, 0f, -10f);
        }
        else if (name == "WriteAReviewButton")
        {

        }
        else if (name == "RemoveAdsButton")
        {

        }
        else if (name == "RestoreButton")
        {

        }
        else if (name == "QuitButton")
        {
            Application.Quit();
        }

    }
}
