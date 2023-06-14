using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManag : MonoBehaviour
{
    public GameObject letterPrefab; // префаб буквы
    public Transform lettersContainer; // контейнер для букв

    private string[] words = { "Apple", "Banana", "Cherry", "Grape", "Orange" };
    private string currentWord;

    // функция для начала новой игры
    public void StartNewGame()
    {
        // выбираем случайное слово
        currentWord = words[Random.Range(0, words.Length)];

        // очищаем контейнер от предыдущих букв
        for (int i = lettersContainer.childCount - 1; i >= 0; i--)
        {
            Destroy(lettersContainer.GetChild(i).gameObject);
        }

        // генерируем новые буквы для текущего слова
        foreach (char letter in currentWord)
        {
            GameObject letterObj = Instantiate(letterPrefab, lettersContainer);
            // расставляем буквы в рандомных позициях
            letterObj.transform.localPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(-3f, 3f));
        }
    }

    // функция для проверки завершения текущего слова
    public bool CheckWordCompleted()
    {
        for (int i = 0; i < lettersContainer.childCount; i++)
        {
            Letter letter = lettersContainer.GetChild(i).GetComponent<Letter>();
            if (!letter.IsConnected())
            {
                return false;
            }
        }
        return true;
    }
}
