using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float shiftDistance = 10.5f;//дистанція зсуву
    private Camera mainCamera;//зберігатимемо тут камеру
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();//отримуємо посилання на камеру
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformPosition = transform.position;//запам'ятовуємо положення
        if (transform.position.y - mainCamera.transform.position.y <= -shiftDistance)//якщо дистанція до камери більша ніж дистанція зсуву 
        {
            transformPosition.y = mainCamera.transform.position.y;//записуємо нові координати
        }
        transform.position = transformPosition;//перезаписуємо положення фону
    }
}
