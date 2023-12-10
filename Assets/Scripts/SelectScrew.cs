using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScrew : MonoBehaviour
    // �������� ���� �������� �� ����� ��� ����� ��������� ���
    // ������ �������� �� ����� ���������� � �������� ���������
{
    public bool boltIsTwisted = true;
    private void OnMouseDown()
    {
        if (boltIsTwisted)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.5f);
            boltIsTwisted = false;
        }
        else
        {
            transform.position = transform.position + new Vector3(0, 0, 0.5f);
            boltIsTwisted = true;
        }
    }
}
