using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 종속성 역전 원칙(DIP) : 상위 수준의 모듈이 하위 수준의 모듈에서 어떤 것도 직접 가져오면 안 된다.
// 이는 높은 결합도의 종속에서 생기는 문제인데 한 클래스에 생기는 오류가 종속되어 있는 모든 클래스에도 영향을 끼치기 때문이다.

// 종속성 역전 원칙을 지키기 위해서는 다음과 같이 설계한다.
// 클래스 간 종속성을 가능한 한 최소화한다.
// 각 클래스가 외부 연결에 의존하지 않게 한다. 내부 로직이나 프라이핏 로직으로 객체를 구성하도록 한다.
// 인터페이스의 추상 함수를 활용한 모듈화로 종속성을 최소화 가능하다.
public class DependencyInversion : MonoBehaviour
{

}