using UnityEngine;

public class SingletonClass : MonoBehaviour
{
    public static SingletonClass instance { get; private set; } // 읽기는 가능하지만, 쓰기를 막아둔다.

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

    public int GetData1() // data1 읽기
    {
        Debug.Log("데이터 1은 " + data1);
        return data1;
    }

    public float GetData2() // data2 읽기
    {
        Debug.Log("데이터 2는 " + data2);
        return data2;
    }

    public void SetData(int data) // data1 쓰기
    {
        data1 = data;
    }

    public void SetData(float data) // data2 쓰기
    {
        data2 = data;
    }
}