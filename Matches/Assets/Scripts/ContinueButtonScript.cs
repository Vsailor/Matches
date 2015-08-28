using UnityEngine;
using System.Collections;

public class ContinueButtonScript : MonoBehaviour {

    public void ContinuePlaying()
    {
        GetComponentInParent<PauseMenuScript>().CurrentLevel.SetActive(true);
        if (this.name == "SolutionButton")
        {
            GetComponentInParent<PauseMenuScript>().CurrentLevel.GetComponent<LevelsScript>().ShowSolution();
        }
    }
}
