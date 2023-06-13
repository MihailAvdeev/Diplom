using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExpViewer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _expText;
    [SerializeField] private string _expPrefix = "";

    private void Start()
    {
        UpdateView();
    }

    private void UpdateView()
    {
        _expText.text = _expPrefix + DataHolder.instance.GetScore().ToString();
    }
}
