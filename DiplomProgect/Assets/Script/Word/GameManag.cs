using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManag : MonoBehaviour
{
    public GameObject letterPrefab; // ������ �����
    public Transform lettersContainer; // ��������� ��� ����

    private string[] words = { "Apple", "Banana", "Cherry", "Grape", "Orange" };
    private string currentWord;

    // ������� ��� ������ ����� ����
    public void StartNewGame()
    {
        // �������� ��������� �����
        currentWord = words[Random.Range(0, words.Length)];

        // ������� ��������� �� ���������� ����
        for (int i = lettersContainer.childCount - 1; i >= 0; i--)
        {
            Destroy(lettersContainer.GetChild(i).gameObject);
        }

        // ���������� ����� ����� ��� �������� �����
        foreach (char letter in currentWord)
        {
            GameObject letterObj = Instantiate(letterPrefab, lettersContainer);
            // ����������� ����� � ��������� ��������
            letterObj.transform.localPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(-3f, 3f));
        }
    }

    // ������� ��� �������� ���������� �������� �����
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
