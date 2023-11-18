using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [HideInInspector] public bool isPause = false;//���� ��� ������ ���� �����
    public GameObject PausePanel;//������ ��������� �� ������ �����

    void Update()//����� ����
    {
        if(Input.GetKeyDown(KeyCode.Escape))//���� ������ ���������
        {
            isPause = !isPause;//������ ���� ����� �� �����������
            if (isPause)//���� � �����
            {
                Time.timeScale = 0;//���������� ���
                PausePanel.SetActive(true);//�������� ������ �����
            }
            else//������
            {
                Time.timeScale = 1;//������� ��������� ���� ����
                PausePanel.SetActive(false);//������ ������ �����
            }
        }
    }
}
