using UnityEngine;

public class SingletonClass : MonoBehaviour
{
    public static SingletonClass instance { get; private set; } // �б�� ����������, ���⸦ ���Ƶд�.

    [Header("Data")]
    private int data1;
    private float data2;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(this.gameObject);
    }

    public int GetData1() // data1 �б�
    {
        Debug.Log("������ 1�� " + data1);
        return data1;
    }

    public float GetData2() // data2 �б�
    {
        Debug.Log("������ 2�� " + data2);
        return data2;
    }

    public void SetData(int data) // data1 ����
    {
        data1 = data;
    }

    public void SetData(float data) // data2 ����
    {
        data2 = data;
    }
}