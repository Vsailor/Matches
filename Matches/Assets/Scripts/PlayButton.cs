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
            if (levels == 100)
            {
                levels = PlayerPrefs.GetInt("CurrentLevel");
            }
        }
        else
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
        
        Levels.transform.GetChild(levels-1).gameObject.SetActive(true);
    }
}
