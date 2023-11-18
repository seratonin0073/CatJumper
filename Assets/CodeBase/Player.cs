using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TMP_Text ScoreText;//посилання на текст рахунку
    public float movementSpeed = 10;//швидкість руху
    private float moveDirection;//напрямок руху
    private Rigidbody2D plaeyRB;//сюди збережемо посилання на фізику героя
    private int score = 0;//рахунок
    
    void Start()
    {
        plaeyRB = GetComponent<Rigidbody2D>();//зберфігаємо посилання на фізику героя
    }

    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal") * movementSpeed;//запам'ятовуємо напрямок рух та швидкість руху
    }

    private void FixedUpdate()
    {
        Move();//рухайся
        if(transform.position.y > score)//якщо висота більша за поточний рахунок
        {
            score = System.Convert.ToInt32(transform.position.y);//записуємо у рахунок значення висоти
            ScoreText.text = score.ToString();//записуємо в текст рахунку значення рахунку
        }
    }

    private void Move()//Метод який реалізовує рух
    {
        Vector2 velocity = plaeyRB.velocity;//запам'ятовуємо швидкість руху
        velocity.x = moveDirection;//міняємо X в залежності від moveDirtection
        plaeyRB.velocity = velocity;//записуємо нову швидкість
    }

    private void OnBecameInvisible()//коли камера не бачить
    {
        Destroy(gameObject);//знищити об'єкт
    }
}
