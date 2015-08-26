using UnityEngine;
using System.Collections;

public class BoxesScript : MonoBehaviour {
    public Texture BoxTexture;
	// Use this for initialization
	void Start () {
        int count = 1;
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 21 && count<=100; j++)
            {
                var box = transform.FindChild("Boxes (" + i + ")").FindChild("Box (" + j + ")");
                box.FindChild("Text").GetComponent<UnityEngine.UI.Text>().text = count.ToString();
                box.GetComponent<UnityEngine.UI.RawImage>().texture = BoxTexture;
                count++;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
