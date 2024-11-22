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
        // 카카오 카드 인스턴스화
        kakaoCard = new KakaoCardStrategy();
        kakaoCard.Init("카카오 카드", "1234 - 5678", "123", "12/25");

        // 루나 카드 인스턴스화
        lunaCard = new LunaCardStrategy();
        lunaCard.Init("lunaCard@gmail.com", "5678");

        // 아이템A 인스턴스화
        Item itemA = new();
        itemA.Init("Chicken", 100);
        shoppingCart.AddItem(itemA);

        // 아이템B 인스턴스화
        Item itemB = new();
        itemB.Init("Fish", 70);
        shoppingCart.AddItem(itemB);

        kakaoCard.ShowCard();
        shoppingCart.Pay(kakaoCard);

        shoppingCart.Pay(lunaCard);
        lunaCard.ShowCard();
    }
}