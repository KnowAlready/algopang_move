using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    private float h; 
    private float v; 
    private int speed = 10;
    private int angle = 0;

    // Update is called once per frame
    void Update()
    {
        h = 0; // 가로 초기화
        v = 0; // 세로 초기화
       
        // Time.deltaTime()의 값은 컴퓨터 성능에 따라 다른며 1 / fps

        // 좌우
        if (Input.GetKey(KeyCode.RightArrow)) // 입력된 키가 오른쪽 키보드면
            h = speed * Time.deltaTime; // 내가 입력한 속도 * 컴퓨터 성능 속도 값만 큼 앞으로 이동(오른쪽)
        else if (Input.GetKey(KeyCode.LeftArrow)) // 입력된 키가 왼쪽 키보드 뒤로 이동( 왼쪽(뒤)이기 때문에 x축으로 -곱해서 이동시킴)
            h = -speed * Time.deltaTime;

        
        if (Input.GetKey(KeyCode.R))
        {
            if (angle < -270)
                angle = 0;
            angle -= 90;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        this.transform.Translate(new Vector3(h, v, 0)); // x,y,z(z는 3차원 -> 우린 필요x) 위치 이동
    }
}
