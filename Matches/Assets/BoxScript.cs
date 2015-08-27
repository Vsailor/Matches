using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {
    public GameObject Levels;
    //public int page;
    UnityEngine.UI.Button button;
	// Use this for initialization
	void Start () {
        button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(()=>{ LoadLevels(); });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadLevels()
    {
        int levels = PlayerPrefs.GetInt("Levels");

        int number = int.Parse(transform.GetComponentInChildren< UnityEngine.UI.Text>().text);
        print(number);
        if (number > levels) return;
        Levels.transform.GetChild(number-1).gameObject.SetActive(true);
        GameObject.Find("LevelMenu").SetActive(false);
    }

   
}
