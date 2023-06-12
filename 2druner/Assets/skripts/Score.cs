using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text textScore;//Переменная для работы с библиотекой текст меш про в юнити. Сюда мы инициализируем наш текст

    [SerializeField] private TMP_Text finalScore;//Переменная для работы с библиотекой текст меш про в юнити. Сюда мы инициализируем наш текст

    [SerializeField] private int score;//Счётчик, который увеличивается каждый кадр в методе update

    private int finalScoreNum;//Переменная нужна для того, чтобы поменять переменные местами

    private void Update()
    {
        textScore.text = "" + score;//Прибавляем пустую строку вместе с переменной счетчика
        score++;//Инкримент(Прибавление на единицу)
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            finalScoreNum = score; //Приравниваем нашу вспомогательную переменную к переменной счетчика
            finalScore.text = "" + finalScoreNum;//Выводим в текст наш итоговый счет
        }
    }
}