using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelsScript : MonoBehaviour {
    public int MaxTakenMatchesCount;
    public int[] StartMatches;
    public System.Collections.Generic.List<int> CurrentPositions;
    int takenMatchesCount;
    public int TakenMatchesCount
    {
        get
        {
            return takenMatchesCount;
        }
        set
        {
            takenMatchesCount = value;
            SetActiveUIMatches(value);
        }
    }
    void Start () {
        TakenMatchesCount = 0;
        CurrentPositions = new System.Collections.Generic.List<int>();
        SetActiveUIMatches(0);
        foreach (var item in StartMatches)
        {
            transform.FindChild("Matches").FindChild("Match (" + item + ")").GetComponent<MatchScript>().SetActive(true);
        }

	}
    public List<int> GetReworkedMatches()
    {
        List<int> answer = new List<int>();

        var currCopy = CurrentPositions.GetRange(0, CurrentPositions.Count);
        var startMatchesCopy = new System.Collections.Generic.List<int>();
        foreach (var item in StartMatches)
        {
            startMatchesCopy.Add(item);
        };
        foreach(var item in currCopy)
        {
            if (!startMatchesCopy.Contains(item))
                answer.Add(item);
        }
        return answer;
    }

    public void SetActiveUIMatches(int count)
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
