using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedSkript : MonoBehaviour
{
    // Переменная для хранения состояния паузы
    private bool isPaused = true;

    // Объект со стартовой заставкой
    public GameObject startScreen;

    // При загрузке сцены
    void Start()
    {
        // Установка паузы в начале игры
        Time.timeScale = 0f;
        isPaused = true;

        // Включение стартовой заставки
        startScreen.SetActive(true);
    }

    // При обновлении кадра
    void Update()
    {
        // Если была нажата любая кнопка
        if (Input.anyKeyDown && isPaused)
        {
            // Скрываем стартовую заставку
            startScreen.SetActive(false);

            // Начинаем игру
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
}
