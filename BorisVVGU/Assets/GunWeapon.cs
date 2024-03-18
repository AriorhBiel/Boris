using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunWeapon : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] float TimeToAttack;
   float Timer;
   PlayerMove playerMove;
    [SerializeField] GameObject bulletPrefab;

    private void Awake() {
        playerMove = GetComponentInParent<PlayerMove>();
    }

    private void Update() {
        if (Timer < TimeToAttack) {
            Timer += Time.deltaTime;
            return;
        }
        Timer = 0;
        SpawnBullet();
    }
    private void SpawnBullet() {
        GameObject shotBullet = Instantiate(bulletPrefab);
        shotBullet.transform.position = transform.position;
        shotBullet.GetComponent<bulletProjectile>().SetDirection(playerMove.lastHorizontalVector, 0f);
    }
}
