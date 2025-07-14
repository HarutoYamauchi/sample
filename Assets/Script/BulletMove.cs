using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//弾の移動
public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed; //弾の速さ
    [SerializeField] private float lifeTime;    //弾の寿命
    [SerializeField] private GameObject bulletPrefab; //弾のプレハブ


    private GameObject bullet; //実体化された弾を格納する変数
    private Rigidbody rb;      //弾にアタッチされたRigidbodyを取得するための変数


    // Start is called once before the first frame Update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //スペースが押されたら
        {
            bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            //Instantiate...objectを出現させる。今回はbullet = を入れることで出現させたobjectをbulletに代入する作業も一緒に行う

            rb = bullet.GetComponent<Rigidbody>();  //bulletのRigidbodyを取得
            rb.AddForce(transform.forward * bulletSpeed);
            //前の方向にbulletSpeedの大きさで力を加える。（）内はベクトル
            //addForceは物を動かす方法の一つ。

            Destroy(bullet, lifeTime);
            //bulletをlifeTime後に壊す
        }
    }
}
