using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [Header("Variable TimeStep")]
    [SerializeField]
    int variableCount1;
    [SerializeField]
    int variableCount2;

    [Header("Fixed TimeStep")]
    [SerializeField]
    int fixedCount;

    void Update() // ���� Ÿ�� ���� 1 : ������ �� ��� �ð��� ���� ���� ������Ʈ
    {
        variableCount1++;
        Debug.Log("���� Ÿ�� ����(1) => " + variableCount1);
    }

    void LateUpdate() // ���� Ÿ�� ���� 2 : Update ���Ŀ� ����
    {
        variableCount2++;
        Debug.Log("���� Ÿ�� ����(2) => " + variableCount2);
    }

    void FixedUpdate() // ���� Ÿ�� ���� : ������ �ʴ� ������ ���
    {
        fixedCount++;
        Debug.Log("���� Ÿ�� ���� => " + fixedCount);
    }
}