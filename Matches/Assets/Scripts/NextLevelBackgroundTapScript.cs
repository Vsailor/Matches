using UnityEngine;
using System.Collections;

public class NextLevelBackgroundTapScript : MonoBehaviour {
    public void OnMouseDown()
    {
        var levelNuber = int.Parse(transform.parent.name.Remove(0, 5));
        PlayerPrefs.SetInt("Levels", levelNuber+1);
        transform.parent.GetComponent<LevelsScript>().NextLevel.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
}
