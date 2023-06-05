using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowStatic : MonoBehaviour
{
    [SerializeField] private TMP_Text HP;
    [SerializeField] private TMP_Text MaxCount;
    void Start()
    {

        Storage.HP = 10;
        Storage.MaxCompleteCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = Storage.HP.ToString(); 
        MaxCount.text = Storage.MaxCompleteCount.ToString(); 
    }


}
