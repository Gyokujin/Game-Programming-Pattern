using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인터페이스 분리 원칙(ISP) : 어떠한 클라이언트도 자신이 사용하지 않는 메서드에 강제로 종속될 수 없다.
// 인터페이스의 규모가 커지지 않도록 클래스와 메서드의 길이를 짧게 유지하라는 의미로 유연성과 집중도를 높인다.
// 한 인터페이스에 너무 많은 기능을 할당하는 것이 아닌 좀 더 특징에 맞게 나누어서 관리하는 게 좋다.(유니티에서는 인터페이스를 조합하는 모듈화 방식을 선호하기 때문에 더욱 중요하다)
// 이 원칙을 준수하면 인터페이스의 불필요한 오버헤드를 피할 수 있다.
public class InterfaceSegregation : MonoBehaviour
{

}