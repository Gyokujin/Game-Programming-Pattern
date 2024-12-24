using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop2 : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1;
    [SerializeField]
    private float operatingTime = 3; // 이 시간이 경과되면 멈추게 한다.
    private bool isOperating = true;

    [SerializeField]
    private Rigidbody rigidbody1; // 물리 이동을 담당할 각각의 컴포넌트 Update, LateUpdate, FixedUpdate 순서이다.
    [SerializeField]
    private Rigidbody rigidbody2;
    [SerializeField]
    private Rigidbody rigidbody3;

    void Start()
    {
        Debug.Log("이동 시작");
        Invoke("Stop", operatingTime);
    }

    void Stop()
    {
        Debug.Log("정지");
        isOperating = false;

        rigidbody1.velocity = Vector3.zero;
        rigidbody1.isKinematic = true;
        Debug.Log("Update 이동량 : " + rigidbody1.position.x);

        rigidbody2.velocity = Vector3.zero;
        rigidbody2.isKinematic = true;
        Debug.Log("LateUpdate 이동량 : " + rigidbody2.position.x);

        rigidbody3.velocity = Vector3.zero;
        rigidbody3.isKinematic = true;
        Debug.Log("FixedUpdate 이동량 : " + rigidbody3.position.x);
    }

    void Update()
    {
        if (isOperating)
            rigidbody1.AddForce(Vector3.right * moveSpeed);
    }

    void LateUpdate()
    {
        if (isOperating)
            rigidbody2.AddForce(Vector3.right * moveSpeed);
    }

    void FixedUpdate()
    {
        if (isOperating)
            rigidbody3.AddForce(Vector3.right * moveSpeed);
    }
}