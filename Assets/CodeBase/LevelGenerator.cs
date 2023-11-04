using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int trapChance = 10;//шанс того що платформа є пасткою
    public int obstacleChance = 15;//шанс випадіння платформи перешкоди
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
            SpawnPlatform(platformPref);//створюємо платформу в певній позиції
        }
    }
    private void SpawnPlatform(GameObject prefab)//метод для спавну платформи
    {
        spawnPos.x = Random.Range(-levelWidth, levelWidth);//задати випадкове значення по ширині
        spawnPos.y += Random.Range(minY, maxY);//додати випадковезначення по висоті спавну
        GameObject platform = Instantiate(prefab, spawnPos, Quaternion.identity);//створити платформу і записуємо її у змінну
        int rnd = Random.Range(1, 101);//генеруємо випадкове значення для перешкоди
        int trapRnd = Random.Range(1, 101);//випадкове значення для пастки
        if(rnd <= obstacleChance)//якщо згенероване число потравило в проміжок від 1 до obstacleChance
        {
            platform.GetComponent<PlatformEffector2D>().enabled = false;//вимикаю PlatformEffector2D
            platform.GetComponentsInChildren<SpriteRenderer>()[0].color = Color.blue;//задаю колір платформи
            platform.GetComponentsInChildren<SpriteRenderer>()[1].color = Color.blue;
            platform.GetComponentsInChildren<SpriteRenderer>()[2].color = Color.blue;
        }
        else if(trapRnd <= trapChance)//якщо згенероване число потрапило в проміжок від 1 до trapChance
        {
            platform.GetComponent<Platform>().isTrap = true;//активуємо флаг пастки
            platform.GetComponentsInChildren<SpriteRenderer>()[0].color = Color.red;//змінюємо колір
            platform.GetComponentsInChildren<SpriteRenderer>()[1].color = Color.red;
            platform.GetComponentsInChildren<SpriteRenderer>()[2].color = Color.red;
        }

    }
}
