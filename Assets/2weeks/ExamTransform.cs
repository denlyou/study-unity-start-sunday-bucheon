using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamTransform : MonoBehaviour
{
    /* 개발자용 부설 : 생명주기 메소드 정리 => https://docs.google.com/document/d/1Skho_drm1dUl3VE1pu6czKr1pvrUsisyoFoaIInZlWk */
    // Start 메소드는 맨처음 프레임에 한번만 실행됩니다.
    void Start()
    {
        // 인스펙터창에 있는 transform 정보는 this.transform 으로 접근할수 있습니다
        /* 개발자용 부설 : 상속받은 MonoBehaviour 클래스의 멤버로 transform 프로퍼티가 가지고 있음
         * 리턴은 Transform 객체 => https://docs.unity3d.com/kr/2018.4/ScriptReference/Transform.html
         */

        // 위치 정보 가져오기 (this.transform.position)
        Debug.Log("x축 위치:" + this.transform.position.x);
        Debug.Log("y축 위치:" + this.transform.position.y);
        Debug.Log("z축 위치:" + this.transform.position.z);
        // 회전 각도 정보 가져오기 (this.transform.rotation)
        Debug.Log("x축 회전:" + this.transform.rotation.x);
        Debug.Log("y축 회전:" + this.transform.rotation.y);
        Debug.Log("z축 회전:" + this.transform.rotation.z);
        // 배율 정보 가져오기 (this.transform.localScale)
        Debug.Log("x축 배율 :" + this.transform.localScale.x);
        Debug.Log("y축 배율 :" + this.transform.localScale.y);
        Debug.Log("z축 배율 :" + this.transform.localScale.z);
    }

    // Update 메소드는 프레임마다 매번 반복해서 실행됩니다.
    void Update()
    {
        // 조금씩 이동
        this.transform.Translate(0.1f, 0.2f, -0.1f);
        /* 좌표로 이동하는 동일한 코드
        this.transform.position = new Vector3(
            this.transform.position.x + 0.1f,
            this.transform.position.y + 0.2f,
            this.transform.position.z - 0.1f
        );
        */
    }
}
