using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordDisplay : MonoBehaviour
{
    public float speed = 30f;
    public TextMeshProUGUI textMesh;

    private string word;

    public void Initialize(string word)
    {
        this.word = word;
        textMesh.text = word.ToUpper();
    }

    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x < -350f)
        {
            Destroy(gameObject);
        }
    }
}
