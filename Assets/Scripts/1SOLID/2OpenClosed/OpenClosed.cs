using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 개방-폐쇄 원칙(OCP) : 클래스가 확장에는 개방적이되 수정에는 폐쇄적이어야 한다.
// 메서드(Method)를 구분 새로운 기능을 추가할 때 기존 코드를 수정할 일을 줄이도록 한다.
// 이는 명확한 함수의 구분으로 각 함수가 어떤 기능을 하는지 알 수 있는 도움을 주기도 한다.

// 클래스를 상속하여 새로운 객체를 정의하며 기존 코드는 보존하면서 새로운 코드의 작성을 적게 하게 한다. (뿌리에서 가지로 확장되는 형태)
// 이로 인해 디버깅도 수월하게 가능하다. 오류가 생겼을 시 기존에 있던 코드가 아닌 새로 작성한 코드 내에서만 분석하면 되기 때문이다.
public class OpenClosed : MonoBehaviour
{

}