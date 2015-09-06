using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour {
    GameObject currentLevel;
    public GameObject CurrentLevel
    {
        get
        {
            return currentLevel;
        }
        set
        {
            currentLevel = value;
            PlayerPrefs.SetInt("CurrentLevel", int.Parse(value.name.Remove(0,5)));

        }
    }
}
