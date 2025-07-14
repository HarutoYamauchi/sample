using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�e�̈ړ�
public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed; //�e�̑���
    [SerializeField] private float lifeTime;    //�e�̎���
    [SerializeField] private GameObject bulletPrefab; //�e�̃v���n�u


    private GameObject bullet; //���̉����ꂽ�e���i�[����ϐ�
    private Rigidbody rb;      //�e�ɃA�^�b�`���ꂽRigidbody���擾���邽�߂̕ϐ�


    // Start is called once before the first frame Update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //�X�y�[�X�������ꂽ��
        {
            bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            //Instantiate...object���o��������B�����bullet = �����邱�Ƃŏo��������object��bullet�ɑ�������Ƃ��ꏏ�ɍs��

            rb = bullet.GetComponent<Rigidbody>();  //bullet��Rigidbody���擾
            rb.AddForce(transform.forward * bulletSpeed);
            //�O�̕�����bulletSpeed�̑傫���ŗ͂�������B�i�j���̓x�N�g��
            //addForce�͕��𓮂������@�̈�B

            Destroy(bullet, lifeTime);
            //bullet��lifeTime��ɉ�
        }
    }
}
