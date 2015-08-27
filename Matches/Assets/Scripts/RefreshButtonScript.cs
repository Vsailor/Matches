using UnityEngine;
using System.Collections;

public class RefreshButtonScript : MonoBehaviour {
    public void RefreshLevel()
    {
        if (!transform.parent.GetComponent<LevelsScript>().CheckVictory())
        {
            transform.GetComponentInParent<LevelsScript>().Init();
        }
    }
}
