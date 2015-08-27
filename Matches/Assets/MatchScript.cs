using UnityEngine;
using System.Collections;

public class MatchScript : MonoBehaviour
{
    public int Number;
    public bool IsActive;
    Sprite DisabledSprite;
    Sprite EnabledSprite;
    void OnMouseDown()
    {
        if (IsActive)
        {
            if (transform.parent.parent.GetComponent<LevelsScript>().MaxTakenMatchesCount >
                transform.parent.parent.GetComponent<LevelsScript>().TakenMatchesCount)
            {
                transform.parent.parent.GetComponent<LevelsScript>().CurrentPositions.Remove(Number);
                transform.parent.parent.GetComponent<LevelsScript>().TakenMatchesCount++;
                SetActive(false);
           }
        }
        else
        {
            if (transform.parent.parent.GetComponent<LevelsScript>().TakenMatchesCount > 0)
            {
                transform.parent.parent.GetComponent<LevelsScript>().TakenMatchesCount--;
                transform.parent.parent.GetComponent<LevelsScript>().CurrentPositions.Add(Number);
                SetActive(true);
            }
        }

    }
    void Start()
    {
        var s = name.Remove(0, name.IndexOf('(')+1);
        Number = int.Parse(s.Remove(s.IndexOf(')')));
        
        EnabledSprite = Resources.Load<Sprite>("Matches_1");
        DisabledSprite = Resources.Load<Sprite>("Matches_2");
    }
    public void SetActive(bool active)
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
