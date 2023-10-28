using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10;//швидкість руху
    private float moveDirection;//напрямок руху
    private Rigidbody2D plaeyRB;//сюди збережемо посилання на фізику героя
    
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
        Vector2 velocity = plaeyRB.velocity;//запам'ятовуємо швидкість руху
        velocity.x = moveDirection;//міняємо X в залежності від moveDirtection
        plaeyRB.velocity = velocity;//записуємо нову швидкість
    }
}
