using UnityEngine;
using System.Collections;

public class SetLevelsNumber : MonoBehaviour {

	// Use this for initialization
    public GameObject Levels;
	void Start () {

        for (int i = 0; i < 100; i++)
        {
            GameObject child = Instantiate(GameObject.Find("LevelNumber"));
            child.transform.SetParent(Levels.transform.GetChild(i));
            child.GetComponent<UnityEngine.UI.Text>().rectTransform.anchoredPosition = GameObject.Find("LevelNumber").GetComponent<UnityEngine.UI.Text>().rectTransform.anchoredPosition;
            child.GetComponent<UnityEngine.UI.Text>().rectTransform.localScale = GameObject.Find("LevelNumber").GetComponent<UnityEngine.UI.Text>().rectTransform.localScale;
            child.GetComponent<UnityEngine.UI.Text>().text = (i+1).ToString() + "/100";
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
