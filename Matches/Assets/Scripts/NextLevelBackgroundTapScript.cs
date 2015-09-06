using UnityEngine;
using System.Collections;

public class NextLevelBackgroundTapScript : MonoBehaviour {
    public GameObject MainMenu;
    public void OnMouseDown()
    {

        var levelNumber = int.Parse(transform.parent.name.Remove(0, 5));
        PlayerPrefs.SetInt("CurrentLevel", levelNumber);
        if (PlayerPrefs.GetInt("Levels") == 100 && levelNumber == 100)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.parent.gameObject.SetActive(false);
            MainMenu.SetActive(true);
            return;
        }
        if (PlayerPrefs.GetInt("Levels") == levelNumber)
        {
            PlayerPrefs.SetInt("Levels", levelNumber + 1);
        }
        transform.parent.GetComponent<LevelsScript>().NextLevel.SetActive(true);
        transform.parent.transform.FindChild("Task").GetComponent<UnityEngine.UI.Text>().text = transform.parent.GetComponent<LevelsScript>().Task;
        this.GetComponent<BoxCollider2D>().enabled = false;
        transform.parent.transform.FindChild("Task").GetComponent<UnityEngine.UI.Text>().enabled = true;
        transform.parent.GetComponent<LevelsScript>().Init();
        transform.parent.gameObject.SetActive(false);
    }
}
