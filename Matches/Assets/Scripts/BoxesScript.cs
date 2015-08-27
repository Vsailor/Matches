using UnityEngine;
using System.Collections;

public class BoxesScript : MonoBehaviour
{
    public Texture BoxTextureClosed;
    public Texture BoxTextureOpen;
    // Use this for initialization
    void Start()
    {
        ShowBoxes();
    }

    public void ShowBoxes()
    {
        int levels = 1;
        if (PlayerPrefs.HasKey("Levels"))
        {
            levels = PlayerPrefs.GetInt("Levels");
        }
        else
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
        int count = 1;
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 21 && count <= 100; j++)
            {
                var box = transform.FindChild("Boxes (" + i + ")").FindChild("Box (" + j + ")");
                box.FindChild("Text").GetComponent<UnityEngine.UI.Text>().text = count.ToString();
                if (count <= levels)
                    box.GetComponent<UnityEngine.UI.RawImage>().texture = BoxTextureOpen;
                else
                    box.GetComponent<UnityEngine.UI.RawImage>().texture = BoxTextureClosed;
                count++;
            }
        }
    }
}
