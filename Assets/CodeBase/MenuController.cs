using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [HideInInspector] public bool isPause = false;//поле яке зберігає стан паузи
    public GameObject PausePanel;//зберігає посилання на панель паузи

    void Update()//кожен кадр
    {
        if(Input.GetKeyDown(KeyCode.Escape))//якщо ескейп натиснуто
        {
            isPause = !isPause;//міняємо стан паузи на протилежний
            if (isPause)//якщо є пауза
            {
                Time.timeScale = 0;//заморожуємо час
                PausePanel.SetActive(true);//показуємо панель паузи
            }
            else//інакше
            {
                Time.timeScale = 1;//ставимо звичайний плин часу
                PausePanel.SetActive(false);//ховаємо панель паузи
            }
        }
    }
}
