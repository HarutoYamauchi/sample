using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSampleScene : MonoBehaviour
{
    //Start is called before the first frame update

    private void Start()
    {

    }

    //Update is called once per frame

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //�X�y�[�X��������Ă�����
        {
            SceneManager.LoadScene("Sample Scene");//SampleScene��ǂݍ���
        }
    }
}