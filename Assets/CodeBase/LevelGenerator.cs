using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public float minY = 1.3f;//мінімальна висота спавну платформи
    public float maxY = 3f;//максимальна висота спавну платформи
    public float levelWidth = 3f;//половина ширини рівня
    public GameObject platformPref;//префаб платформи
    public int numberOfPlatform = 5;//кількість платформ яка буде створена при старті

    private Vector3 spawnPos;//позиція в якій буде створена платформа
    void Start()
    {
        for (int i = 0; i < numberOfPlatform; i++)//від 0 до кількості платформ при старті(не включно)
        {
            spawnPos.x = Random.Range(-levelWidth, levelWidth);//задати випадкове значення по ширині
            spawnPos.y += Random.Range(minY, maxY);//задати випадковезначення по висоті спавну
            Instantiate(platformPref, spawnPos, Quaternion.identity);//створити платформу
        }
    }
}
