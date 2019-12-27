using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamPropertiy : MonoBehaviour
{
    // 전역 변수 : 모든 메소드에서 공통으로 접근 할수 있는 변수
    /* 개발자 버전 : ExamIfTranslate 클래스의 멤버 프로퍼티들 */
    int property = 0;

    void Start()
    {
        property = 1;
        Debug.Log("[Start] property: " + property);
    }

    void Update()
    {
        // 전역 변수인 property는 start, update 뿐만 아니라 다른 메소드에서도 사용이 가능합니다.
        property++; // 기존값에 +1을 합니다. (property = property + 1;과 동일)
        Debug.Log("[Update] property: " + property);
    }
}
