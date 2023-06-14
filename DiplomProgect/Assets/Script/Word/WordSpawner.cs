using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public string[] words;

    private void Start()
    {
        StartCoroutine(SpawnWords());
    }

    private IEnumerator SpawnWords()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);

            GameObject wordObj = Instantiate(wordPrefab, wordCanvas);
            WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

            int randomIndex = Random.Range(0, words.Length);
            string randomWord = words[randomIndex];

            wordDisplay.Initialize(randomWord);
        }
    }
}
