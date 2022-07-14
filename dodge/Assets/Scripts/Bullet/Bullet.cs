using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; // 총알의 송력
    private GameManager gameManager;
    private Rigidbody bulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>(); // 게임 오브젝트에서 리지드바디 찾음
        bulletRigidbody.velocity = transform.forward * speed; // 리지드바디 속도 설정
        Destroy(gameObject, 3f); // 3초뒤 총알 죽음
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null) // 플레이어컨트롤러와 충돌하면 플레이어 컨트롤러 죽음
            {
                //playerController.Die();
            }
        }
    }
    void Update()
    {
        if (gameManager.isGameOver)
        {
            this.transform.Rotate(0f, 5000 * Time.deltaTime, 0f);
        }
    }
}
public class Attact : Bullet
{

}
public class Heal : Bullet
{

}
