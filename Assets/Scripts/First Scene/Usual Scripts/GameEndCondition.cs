using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndCondition : MonoBehaviour
{
    private HashSet<GameObject> itemsInTruckBed = new HashSet<GameObject>();  // ��������� ��� ������������ ��������� � ������
    private int totalItemsCount;  // ����� ���������� ���������

    void Start()
    {
        // ������� ��� ������� � ����� "HouseholdItem"
        totalItemsCount = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ������ ����� ������ ���
        if (other.CompareTag("Item"))
        {
            // ��������� ������� � ���������, ���� �� �������� ������
            itemsInTruckBed.Add(other.gameObject);
            CheckEndCondition();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // ������� ������� �� ���������, ���� �� �������� �����
        if (other.CompareTag("Item"))
        {
            itemsInTruckBed.Remove(other.gameObject);
        }
    }

    void CheckEndCondition()
    {
        // ���� ���������� ��������� � ������ ����� ������ ����������, ��������� ����
        if (itemsInTruckBed.Count == totalItemsCount)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("��� �������� ���������! ���� ���������.");
        // ����� ����� �������� ������ ���������� ����, ��������, ������� �� ����� ������
    }
}
