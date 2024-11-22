using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakaoCardStrategy : PaymentStrategy
{
    private string cardName;
    private string cardNumber;
    private string cvv;
    private string dateOfExpiry;

    public void Init(string _cardName, string _cardNumber, string _cvv, string _dateOfExpiry)
    {
        cardName = _cardName;
        cardNumber = _cardNumber;
        cvv = _cvv;
        dateOfExpiry = _dateOfExpiry;
    }

    public override void ShowCard()
    {
        Debug.Log("카드 이름 : " + cardName);
        Debug.Log("카드 번호 : " + cardNumber);
        Debug.Log("CVV : " + cvv);
        Debug.Log("유효기간 : " + dateOfExpiry);
    }

    public override void Pay(int amount)
    {
        Debug.Log(amount + "원을 카카오 카드로 결제");
    }
}