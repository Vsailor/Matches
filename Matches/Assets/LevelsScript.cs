using UnityEngine;
using System.Collections;

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
    public bool MovementDone()
    {
        var currCopy = CurrentPositions.GetRange(0, CurrentPositions.Count);
        var startMatchesCopy = new System.Collections.Generic.List<int>();
        foreach (var item in StartMatches)
        {
            startMatchesCopy.Add(item);
        }
        currCopy.Sort();
        startMatchesCopy.Sort();
        int counter = 0;
        for (int i = 0; i < currCopy.Count; i++)
        {
            if (currCopy[i] != startMatchesCopy[i])
            {
                counter++;
            }
        }
        if (counter / 2 == MaxTakenMatchesCount)
        {
            return true;
        }
        return false;
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
