using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Image : MonoBehaviour
{
    public GameObject panel_Win;
    public GameObject panel_loz;
    [SerializeField]private bool _pos;
    
    void OnMouseDown()
    {
        if (_pos)
            OnClickPas();
        else
            OnClickNeg();
        Destroy(gameObject);
    }

    public void OnClickPas()
    {
        Storage.MaxCompleteCount++;

    }
    public void OnClickNeg()
    {
        Storage.HP--;
    }
    void Update()
    {
        if (Storage.HP == 0)
        {
            panel_loz.SetActive(true);
            Time.timeScale = 0f;
        } 
        if (Storage.MaxCompleteCount == 10)
        {
            panel_Win.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
public static class Storage
{
    public static int MaxCompleteCount { get; set; }
    public static int HP { get; set; }
    
}

