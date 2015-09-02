using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelsScript : MonoBehaviour
{
    public GameObject NextLevel;
    public int MaxTakenMatchesCount;
    public int[] StartMatches;
    public int[] FinishMatches;
    public System.Collections.Generic.List<int> CurrentPositions;
    int takenMatchesCount;
    public string Task;
    public int StartTakenMatchesCount;
    public void Init()
    {
        Start();
    }
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
    void Start()
    {
        transform.FindChild("CongratulationsMessage").GetComponent<SpriteRenderer>().enabled = false;
        transform.FindChild("TapScreen").GetComponent<BoxCollider2D>().enabled = false;
        Task = transform.FindChild("Task").GetComponent<UnityEngine.UI.Text>().text;
        TakenMatchesCount = StartTakenMatchesCount;
        CurrentPositions = new System.Collections.Generic.List<int>();
        foreach (var item in StartMatches)
        {
            CurrentPositions.Add(item);
        };
        SetActiveUIMatches(TakenMatchesCount);
        for (int i = 0; i < transform.FindChild("Matches").childCount; i++)
        {
            transform.FindChild("Matches").FindChild("Match (" + (i + 1) + ")").GetComponent<MatchScript>().Init();
            transform.FindChild("Matches").FindChild("Match (" + (i+1) + ")").GetComponent<MatchScript>().SetActive(false);
        }
        foreach (var item in StartMatches)
        {
            transform.FindChild("Matches").FindChild("Match (" + item + ")").GetComponent<MatchScript>().Init();
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
        foreach (var item in currCopy)
        {
            if (!startMatchesCopy.Contains(item))
                answer.Add(item);
        }
        return answer;
    }
    public bool CheckVictory()
    {

        var currCopy = CurrentPositions.GetRange(0, CurrentPositions.Count);
        var finishMatchesCopy = new System.Collections.Generic.List<int>();
        foreach (var item in FinishMatches)
        {
            finishMatchesCopy.Add(item);
        };
        currCopy.Sort();
        finishMatchesCopy.Sort();
        if (currCopy.Count != finishMatchesCopy.Count) return false;
        for (int i = 0; i<currCopy.Count; i++)
        {
            if (currCopy[i] != finishMatchesCopy[i])
                return false;
        }
        return true;

    }
    public void ShowSolution()
    {

        CurrentPositions.Clear();
        var matches = transform.FindChild("Matches");
        for (int i = 0; i < matches.childCount; i++)
        {
            matches.FindChild("Match (" + (i + 1) + ")").gameObject.GetComponent<MatchScript>().SetActive(false);
        }
        for (int i = 0; i < FinishMatches.Length; i++)
        {
            matches.FindChild("Match (" + FinishMatches[i] + ")").gameObject.GetComponent<MatchScript>().SetActive(true);
            CurrentPositions.Add(FinishMatches[i]);
        }
        transform.FindChild("Task").GetComponent<UnityEngine.UI.Text>().text = "Solution:";
        transform.FindChild("TapScreen").GetComponent<BoxCollider2D>().enabled = true;
    }

    public void SetActiveUIMatches(int count)
    {
        var uiMatches = transform.FindChild("UIMatches");       
        for (int i = count + 1; i <= uiMatches.childCount; i++)
        {
            (uiMatches.transform.FindChild("UIMatch (" + i + ")")).gameObject.SetActive(false);
        }
        for (int i = 1; i <= count; i++)
        {
            (uiMatches.transform.FindChild("UIMatch (" + i + ")")).gameObject.SetActive(true);
        }
    }
    public void ShowCongratulationMessage()
    {
        transform.FindChild("Task").GetComponent<UnityEngine.UI.Text>().enabled = false;
        transform.FindChild("CongratulationsMessage").GetComponent<SpriteRenderer>().enabled = true;
        transform.FindChild("TapScreen").GetComponent<BoxCollider2D>().enabled = true;
    }
}
