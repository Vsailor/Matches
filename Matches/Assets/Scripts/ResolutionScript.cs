using UnityEngine;
using System.Collections;

public class ResolutionScript : MonoBehaviour
{
    public Transform MainBackground;
    public Transform LevelsBackground;
    void Start()
    {
        transform.position = new Vector3(0f, 0f, -10f);
    }
    void Update()
    {
        var resolution = string.Empty;
        float height = 0.5280859f;
        try
        {
            resolution = (Screen.width * 1.0 / Screen.height * 1.0).ToString().Substring(0, 4);
        }
        catch (System.ArgumentOutOfRangeException)
        {
            resolution = (Screen.width * 1.0 / Screen.height * 1.0).ToString();
        }
        MainBackground.localScale = new Vector3(float.Parse(resolution) / 1.05f, height, 1f);
    }
}
