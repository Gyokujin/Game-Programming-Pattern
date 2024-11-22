using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyEditor : MonoBehaviour
{
    [SerializeField]
    private ShoppingCart shoppingCart;
    private KakaoCardStrategy kakaoCard;
    private LunaCardStrategy lunaCard;

    void Start()
    {
        // īī�� ī�� �ν��Ͻ�ȭ
        kakaoCard = new KakaoCardStrategy();
        kakaoCard.Init("īī�� ī��", "1234 - 5678", "123", "12/25");

        // �糪 ī�� �ν��Ͻ�ȭ
        lunaCard = new LunaCardStrategy();
        lunaCard.Init("lunaCard@gmail.com", "5678");

        // ������A �ν��Ͻ�ȭ
        Item itemA = new();
        itemA.Init("Chicken", 100);
        shoppingCart.AddItem(itemA);

        // ������B �ν��Ͻ�ȭ
        Item itemB = new();
        itemB.Init("Fish", 70);
        shoppingCart.AddItem(itemB);

        kakaoCard.ShowCard();
        shoppingCart.Pay(kakaoCard);

        shoppingCart.Pay(lunaCard);
        lunaCard.ShowCard();
    }
}