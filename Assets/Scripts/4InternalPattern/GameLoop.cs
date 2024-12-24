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

    void Update() // 가변 타임 스텝 1 : 프레임 간 경과 시간에 따른 동적 업데이트
    {
        variableCount1++;
        Debug.Log("가변 타임 스텝(1) => " + variableCount1);
    }

    void LateUpdate() // 가변 타임 스텝 2 : Update 이후에 실행
    {
        variableCount2++;
        Debug.Log("가변 타임 스텝(2) => " + variableCount2);
    }

    void FixedUpdate() // 고정 타임 스텝 : 지정된 초당 프레임 사용
    {
        fixedCount++;
        Debug.Log("고정 타임 스텝 => " + fixedCount);
    }
}