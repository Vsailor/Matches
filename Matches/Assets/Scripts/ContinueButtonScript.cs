using UnityEngine;
using System.Collections;

public class ContinueButtonScript : MonoBehaviour {
    public void ContinuePlaying()
    {
        GetComponentInParent<PauseMenuScript>().CurrentLevel.SetActive(true);
    }
}
