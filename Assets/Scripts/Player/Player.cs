using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int startHp;
    int Hp;
    public float bulletcooldown;
    float bulletTimer;
    void Start()
    {
        Hp = startHp;
    }
    void Update()
    {
        bulletTimer -= Time.deltaTime;
    }
      private void OnTriggerEnter2D(Collider2D colission)
    {
        if (colission.tag == "Bullet" && bulletTimer <= 0)
      {
        Hp -= 1;
        print(Hp);
        bulletTimer = bulletcooldown;
      }
    }
}
