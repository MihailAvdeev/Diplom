using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedSkript : MonoBehaviour
{
    // ���������� ��� �������� ��������� �����
    private bool isPaused = true;

    // ������ �� ��������� ���������
    public GameObject startScreen;

    // ��� �������� �����
    void Start()
    {
        // ��������� ����� � ������ ����
        Time.timeScale = 0f;
        isPaused = true;

        // ��������� ��������� ��������
        startScreen.SetActive(true);
    }

    // ��� ���������� �����
    void Update()
    {
        // ���� ���� ������ ����� ������
        if (Input.anyKeyDown && isPaused)
        {
            // �������� ��������� ��������
            startScreen.SetActive(false);

            // �������� ����
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
}
