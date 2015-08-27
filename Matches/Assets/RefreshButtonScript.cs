using UnityEngine;
using System.Collections;

public class RefreshButtonScript : MonoBehaviour {
    public void RefreshLevel()
    {
        transform.GetComponentInParent<LevelsScript>().Init();
    }
}
