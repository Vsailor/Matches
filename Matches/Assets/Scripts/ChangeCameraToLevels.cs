using UnityEngine;
using System.Collections;

public class ChangeCameraToLevels : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        var MyButton = this.gameObject.GetComponent<UnityEngine.UI.Button>();
        MyButton.onClick.AddListener(() => { Click(); });
    }

    public void Click()
    {
        var levels = GameObject.Find("LevelMenu");
        levels.GetComponent<Canvas>().enabled = true;
    }


    // Update is called once per frame
    void Update()
    {

    }

}
