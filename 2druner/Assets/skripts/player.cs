using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private GameObject DeathScreen; //Экран при смерти

    [SerializeField] private float jumpVelocity = 20f; //сила прыжка

    private Animator animation;//Импортируем компонент animator

    private Rigidbody2D rigidbody;

    private bool jump = false;//Булевая переменная, проверяющая наличие земли под ногами

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();//Объявляем компонент rigidbody при старте игры внутри персонажа
        animation = GetComponent<Animator>();//Объявляем компонент animator при старте игры внутри персонажа
        Time.timeScale = 1f; //Время течет в игре в нормальной скорости
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space) && jump == false)//Проверка, нажата ли клавиша пробели есть ли земля под ногами
        {
            rigidbody.velocity = new Vector3(0, jumpVelocity, 0); //Меняем гравитациюигрока на значение силы прыжка
            animation.SetBool("Jump", true);//Внутри аниматора передаём в булевую переменную Jump значение True
            jump = true; //Переводим нашу переменную проверки прыжка в true
        }
    }

    private void OnCollisionEnter2D(Collision2D other)//Метод для проверки на сопротивление с коллайдером объекта
    {

        if(other.gameObject.tag == "LocationTemplate")//Проверка на соприкосновение с землей у которой тег LocationTempLate        
        {
            animation.SetBool("Jump", false);//Отключаем анимацию прыжка
            jump = false; //При соприкосновении с полом обнуляется булевая переменная что бы не было двойного прыжка
        }

        if(other.gameObject.tag == "Obstacle")//проверка на соприкосновение с препятствиями
        {
            DeathScreen.SetActive(true); //Включение экрана смерти при столкновении с припятствием
            Time.timeScale = 0f; //остановка времени
        }
    }
}   
