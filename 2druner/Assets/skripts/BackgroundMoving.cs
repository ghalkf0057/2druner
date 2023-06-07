using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float BackgroundMoving = 2f; //Начальная скорость, которая меняется внутри проекта при желании

    //{SerializeField} - встоенная функция юнити, позволяющая изменять значение переменной из инспектора, а не из кода
    //private - объявление приватности переменной
    // float - тип переменной с плавующей точкой (В конце цифры обязательно необходимо дописать 'f', этого требует объявление типа float)
    //speed - название переменной для сокрости нашего объекта


    //Встроенный метод unity, который вызывается каждый кадр во время игры
    private void Update()
    {
      transform.position -= new Vector3 (BackgroundMoving* Time.deltaTime, 0, 0); //Умножается скорость на время
      //В данной строчке мы вычитаем из позиции объекта Vector3, который принимает в себя 3 переменные вектора x, y, z
      Debug.Log(transform.position);

    }
}    