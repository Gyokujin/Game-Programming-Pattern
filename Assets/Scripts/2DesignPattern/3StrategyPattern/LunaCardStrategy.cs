using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaCardStrategy : PaymentStrategy
{
    private string emailId;
    private string password;

    public void Init(string _emailId, string _password)
    {
        emailId = _emailId;
        password = _password;
    }

    public override void ShowCard()
    {
        Debug.Log("이메일 : " + emailId);
        Debug.Log("비밀번호 : " + password);
    }

    public override void Pay(int amount)
    {
        Debug.Log(amount + "원을 루나 카드로 결제");
    }
}