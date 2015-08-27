using UnityEngine;
using System.Collections;

public class MatchScript : MonoBehaviour
{
    public bool IsActive;
    Sprite DisabledSprite;
    Sprite EnabledSprite;
    void OnMouseDown()
    {
        SetActive(!IsActive);
    }
    void Start()
    {
        EnabledSprite = Resources.Load<Sprite>("Matches_1");
        DisabledSprite = Resources.Load<Sprite>("Matches_2");
    }
    void SetActive(bool active)
    {
        IsActive = active;
        if (active)
        {
            GetComponent<SpriteRenderer>().sprite = EnabledSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = DisabledSprite;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
