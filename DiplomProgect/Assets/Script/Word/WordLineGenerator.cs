using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordLineGenerator : MonoBehaviour
{
    public string word = "Unity"; // ����������� �����
    public Transform lineStartPoint; // ��������� ����� �����
    public Transform lineEndPoint; // �������� ����� �����

    private void Start()
    {
        GenerateWordLine();
    }

    private void GenerateWordLine()
    {
        Vector3 lineDirection = (lineEndPoint.position - lineStartPoint.position).normalized;
        float letterSpacing = Vector3.Distance(lineStartPoint.position, lineEndPoint.position) / (word.Length - 1);

        for (int i = 0; i < word.Length; i++)
        {
            Vector3 letterPosition = lineStartPoint.position + lineDirection * (i * letterSpacing);
            Quaternion letterRotation = Quaternion.LookRotation(lineDirection);

            GameObject letterObject = new GameObject("Letter " + i);
            letterObject.transform.position = letterPosition;
            letterObject.transform.rotation = letterRotation;
            letterObject.transform.SetParent(transform);

            // �������� ���� ��� ��� ����������� ����� (��������, �������� �������, �������� � �. �.)
        }
    }
}
