using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedY;

    //X�������̐���
    [SerializeField] private float XMax;
    [SerializeField] private float XMin;

    //Y�������̐���
    [SerializeField] private float YMax;
    [SerializeField] private float YMin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //D�������Ă���Ƃ��@���@���̃I�u�W�F�N�g��X���W��XMax��菬�����Ƃ�
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < XMax)
        {
            //X���̐��̌����Ɉړ�
            transform.Translate(new Vector3(SpeedX, 0, 0) * Time.deltaTime);
        }

        //A�������Ă���Ƃ��@���@���̃I�u�W�F�N�g��X���W��XMin���傫���Ƃ�
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > XMin)
        {
            //X���̕��̌����Ɉړ�
            transform.Translate(new Vector3(-SpeedX, 0, 0) * Time.deltaTime);
        }

        //W�������Ă���Ƃ��@���@���̃I�u�W�F�N�g��Y���W��YMax��菬�����Ƃ�
        if (Input.GetKey(KeyCode.W) && this.transform.position.y < YMax)
        {
            //Y���̐��̌����Ɉړ�
            transform.Translate(new Vector3(0, SpeedY, 0) * Time.deltaTime);
        }
        //S�������Ă���Ƃ��@���@���̃I�u�W�F�N�g��Y���W��YMin���傫���Ƃ�
        if (Input.GetKey(KeyCode.S) && this.transform.position.y > YMin)
        {
            //Y���̕��̌����Ɉړ�
            transform.Translate(new Vector3(0, -SpeedY, 0) * Time.deltaTime);
        }

    }

    //�I�u�W�F�N�g�ɐG�ꂽ�������m����R�[�h��ǉ�

    private void OnTriggerEnter(Collider other)//other�ɂ͂Ԃ������I�u�W�F�N�g���������
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            Destroy(this.gameObject);
        }
    }
}
