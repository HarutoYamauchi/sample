using UnityEngine;

public class EnemyMoveb : MonoBehaviour
{
    [SerializeField] private float enemySpeed = -5;
    [SerializeField] private float enemyLifeTime;//�ǉ�
    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemySpeed) * Time.deltaTime);//�G���������ɗ����Ă���

        //�ȉ��̃R�[�h��ǉ�
        //����LifeTime���O��菬�����Ȃ�����
        if (enemyLifeTime < 0)
        {
            Destroy(this.gameObject);//���̃I�u�W�F�N�g���폜
        }
    }
    private void OnTriggerEnter(Collider other)//other�ɂ͂Ԃ������I�u�W�F�N�g���������
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}