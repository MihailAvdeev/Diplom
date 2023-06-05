using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Lutter : MonoBehaviour, IPointerEnterHandler
{
    public LinerChec LinerChec;
    [SerializeField] private int _pos;


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_pos == LinerChec.score)
        {
            LinerChec.score++;
            Debug.Log(_pos + "" + LinerChec.score);
        }
    }

}
