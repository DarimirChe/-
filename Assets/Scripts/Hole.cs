using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] GameObject _holeTrigger; // ������ �� ������ ��������
    [SerializeField] GameObject _screw; // ������ �� ������ �����
    [SerializeField] Transform _spawnPoint;
    [SerializeField] private bool _isOpen = true;

    private void OnMouseDown() // ����� �� ��������� ������
    {
        Debug.Log("OnMouseDown " + gameObject.name);
        Krytit();
    }

    public void Krytit()
    {
        if (_isOpen && GlobalScrewStatus.isHaveScrew) // ���� ��������� "�������" � ���� ������
        {
            GlobalScrewStatus.CurrentScrew.Move(_spawnPoint.position);
            GlobalScrewStatus.isHaveScrew = false;
            GlobalScrewStatus.CurrentScrew = null;
        }
    }

    public void SetOpen(bool isOpen)
    {
        _isOpen = isOpen;
    }
}