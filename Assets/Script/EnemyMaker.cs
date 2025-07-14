using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float makeTime;//���b��Ɏ���Enemy�𐶐����邩�������b��
    private float waitTime;//Enemy�𐶐����Ă��牽�b�o����������������
    [SerializeField] private float enemyZ;//Enemy�𐶐�����Z���W
    [SerializeField] private float enemyX;//Enemy�𐶐�����X���W
    private float ranX;//�����_����X���W������

    void Start()
    {

    }

    void Update()
    {
        //�G����ʂɌ����܂ł̎��Ԃ𐔂���
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
            //waitTime�Ƀt���[���Ԃ̎��Ԃ𑫂������邱�ƂŃ^�C�}�[�̖������ʂ���
        }
        //waitTime��makeTime���傫���Ȃ�����
        else
        {
            ranX = Random.Range(enemyX * -1, enemyX);
            //ranX�ɂ�-enemy����enemyX�܂ł̃����_���Ȑ��������ꎚ

            Instantiate(enemyPrefab, new Vector3(ranX, 0, enemyZ), enemyPrefab.transform.rotation);
            //�I�u�W�F�N�g���o��������ienemyPrefab���A(ranX, 0, enemyZ)�̍��W�ɁAenemyPrefab��rotation�̊p�x�Łj

            waitTime = 0;//waitTime���O�ɂ��邱�ƂŁA������x�G���o��������܂ł̎��Ԃ𐔂���
        }
    }
}
