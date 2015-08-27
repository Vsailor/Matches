using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
    public GameObject Levels;
	// Use this for initialization
 public void LoadLastLevel()
    {
        int levels = 1;
        if (PlayerPrefs.HasKey("Levels"))
        {
            levels = PlayerPrefs.GetInt("Levels");
        }
        else
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
        
        Levels.transform.GetChild(levels).gameObject.SetActive(true);
        GameObject.Find("LevelMenu").SetActive(false);
    }
}
