using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float shiftDistance = 10.5f;//��������� �����
    private Camera mainCamera;//������������ ��� ������
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();//�������� ��������� �� ������
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformPosition = transform.position;//�����'������� ���������
        if (transform.position.y - mainCamera.transform.position.y <= -shiftDistance)//���� ��������� �� ������ ����� �� ��������� ����� 
        {
            transformPosition.y = mainCamera.transform.position.y;//�������� ��� ����������
        }
        transform.position = transformPosition;//������������ ��������� ����
    }
}
