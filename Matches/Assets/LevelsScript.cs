using UnityEngine;
using System.Collections;

public class LevelsScript : MonoBehaviour {
    public GameObject[] StartMatches;
	void Start () {
        // Clear UI matches
        SetActiveUIMatches(0);
        // Set color matches
        var sprite = Resources.Load<Sprite>("Matches_1");
        foreach (var item in StartMatches)
        {
            item.SendMessage("SetActive", true);
        }
        var matches = transform.FindChild("Matches");

	}
    void SetActiveUIMatches(int count)
    {
        var uiMatches = transform.FindChild("UIMatches");
        for (int i = count+1; i <= 5; i++)
        {
            (uiMatches.transform.FindChild("UIMatch (" + i + ")")).gameObject.SetActive(false);
        }
        for (int i = 1; i <= count; i++)
        {
            (uiMatches.transform.FindChild("UIMatch (" + i + ")")).gameObject.SetActive(true);
        }
    }

	void Update () {
    }
}
