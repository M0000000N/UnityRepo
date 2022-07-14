using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; // �Ѿ��� �۷�
    private GameManager gameManager;
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>(); // ���� ������Ʈ���� ������ٵ� ã��
        bulletRigidbody.velocity = transform.forward * speed; // ������ٵ� �ӵ� ����
        Destroy(gameObject, 3f); // 3�ʵ� �Ѿ� ����
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (playerController != null) // �÷��̾���Ʈ�ѷ��� �浹�ϸ� �÷��̾� ��Ʈ�ѷ� ����
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
