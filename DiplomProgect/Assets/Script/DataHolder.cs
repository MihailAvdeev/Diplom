using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
    public static DataHolder instance;
    
    private int Score;


    void Awake()
    {
        if (DataHolder.instance != null && DataHolder.instance != this)
            Destroy(this.gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void AddScore(int count)
    {
        Score += count;
    }

    public void ReduceScore(int count)
    {
        Score -= count;
    }

    public int GetScore() => Score;
    
}
