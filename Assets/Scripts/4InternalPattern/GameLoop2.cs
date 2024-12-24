using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop2 : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1;
    [SerializeField]
    private float operatingTime = 3; // �� �ð��� ����Ǹ� ���߰� �Ѵ�.
    private bool isOperating = true;

    [SerializeField]
    private Rigidbody rigidbody1; // ���� �̵��� ����� ������ ������Ʈ Update, LateUpdate, FixedUpdate �����̴�.
    [SerializeField]
    private Rigidbody rigidbody2;
    [SerializeField]
    private Rigidbody rigidbody3;

    void Start()
    {
        Debug.Log("�̵� ����");
        Invoke("Stop", operatingTime);
    }

    void Stop()
    {
        Debug.Log("����");
        isOperating = false;

        rigidbody1.velocity = Vector3.zero;
        rigidbody1.isKinematic = true;
        Debug.Log("Update �̵��� : " + rigidbody1.position.x);

        rigidbody2.velocity = Vector3.zero;
        rigidbody2.isKinematic = true;
        Debug.Log("LateUpdate �̵��� : " + rigidbody2.position.x);

        rigidbody3.velocity = Vector3.zero;
        rigidbody3.isKinematic = true;
        Debug.Log("FixedUpdate �̵��� : " + rigidbody3.position.x);
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