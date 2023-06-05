using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpavnImaj : MonoBehaviour
{
    [SerializeField] private GameObject img;
    [SerializeField] private GameObject[] imaj;
    public float[] positions;
    

    void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(imaj[Random.Range(0, imaj.Length)], new Vector3(positions[Random.Range(0, 4)], 6f, 0f), Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(2.5f);
        }
    }
}
