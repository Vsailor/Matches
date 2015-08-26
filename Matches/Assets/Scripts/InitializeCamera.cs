using UnityEngine;
using System.Collections;

public class InitializeCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {

        var levels=GameObject.Find("LevelMenu");
        levels.GetComponent<Canvas>().enabled=false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
