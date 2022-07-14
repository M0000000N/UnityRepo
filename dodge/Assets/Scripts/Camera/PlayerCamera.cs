using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject Target;
    public float offsetX;
    public float offsetY;
    public float offsetZ;

    private float Speed = 10f;
    private float rotateSpeed = 10f;
    Vector3 TargetPos;

    float h, v;

    private void FixedUpdate()
    {
        TargetPos = new Vector3(Target.transform.position.x + offsetX, Target.transform.position.y + offsetY, Target.transform.position.z + offsetZ);

        //transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * Speed);
        transform.rotation = Quaternion.Euler(40, 0, 0);

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        // 바라보는 방향으로 회전 후 다시 정면을 바라보는 현상을 막기 위해 설정
        if (!(h == 0 && v == 0)) // h, v
        {
            // 이동과 회전을 함께 처리
            transform.position += dir * Speed * Time.deltaTime;
            // 회전하는 부분. Point 1.
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        }
    }
}
