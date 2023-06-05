using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSkript : MonoBehaviour
{
    public TMP_Text qText;
    public TMP_Text[] answersText;
    public QuestionList[] question;

    List<object> qList;
    QuestionList crntQ;
    int randQ;

    public void OnClickPlay()
    {
        qList = new List<object>(question);
        questionGenerate();
    }
    void questionGenerate()
    {
        if (qList.Count > 0)
        {
        randQ = Random.Range(0, qList.Count);
        crntQ = qList[randQ] as QuestionList;
        qText.text = crntQ.question;
        List<string> answers = new List<string>(crntQ.answers);
        for (int i = 0; i < crntQ.answers.Length; i++)
        {
            int rand = Random.Range(0, answers.Count);
            answersText[i].text = answers[rand];
            answers.RemoveAt(rand);
        }
        }
        else
        {
            print("Вы прошли игру");
        }
        
        //qText.text = question[Random.Range(0, question.Length)].question;
    }
    public void AnswersBttns(int index)
    {
        if (answersText[index].text.ToString() == crntQ.answers[0]) print("Ответ Правильный");
        else print("Не правильный");
        qList.RemoveAt(randQ);
        questionGenerate();
    }

}
[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[3];
}
