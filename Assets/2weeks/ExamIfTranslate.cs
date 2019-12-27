using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// if문과 transform.Translate 메소드를 활용한 좌우 왔다갔다 예제
/// </summary>
public class ExamIfTranslate : MonoBehaviour
{
    bool isRightMove = true; // 오를쪽으로 왼쪽으로 갈지 가지고 있을 (전역) 변수

    void Update()
    {
        if (isRightMove) // 오른쪽로 움직일까요?
        {   // true면 오른쪽으로 움직입니다.
            this.transform.Translate(0.1f, 0, 0);
            // x축 위치가 10이 넘어가는지 확인합니다. (중첩 if)
            if (this.transform.position.x > 10)
            {
                isRightMove = false; // 반대로 움직이도록 변수를 false 바꿉니다
            }
        }
        else
        {   // false면 왼쪽으로 움직입니다.
            this.transform.Translate(-0.1f, 0, 0);
            // x축 위치가 0이 이하인지 확인합니다. (중첩 if)
            if (this.transform.position.x < 0)
            {
                isRightMove = true; // 다시 반대로 움직이도록 합니다.
            }
        }
    }
}
