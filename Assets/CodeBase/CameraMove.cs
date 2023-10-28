using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 100f;//швидкість камери

    private Transform target;//об'єкт за яким буде камера слідкувати 
    void Start()
    {
        target = FindObjectOfType<Player>().transform;//шукаємо таргет за скриптом Player
    }

    void Update()
    {
        if (target.position.y > transform.position.y)//якщо таргет вище за камеру
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, -10);//створюємо те куди камера буде рухатись
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * speed);//рухаємо камеру в новову позицію
        }
    }
}
