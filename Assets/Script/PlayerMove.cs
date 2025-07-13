using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedY;

    //X軸方向の制限
    [SerializeField] private float XMax;
    [SerializeField] private float XMin;

    //Y軸方向の制限
    [SerializeField] private float YMax;
    [SerializeField] private float YMin;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Dを押しているとき　かつ　このオブジェクトのX座標がXMaxより小さいとき
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < XMax)
        {
            //X軸の正の向きに移動
            transform.Translate(new Vector3(SpeedX, 0, 0) * Time.deltaTime);
        }

        //Aを押しているとき　かつ　このオブジェクトのX座標がXMinより大きいとき
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > XMin)
        {
            //X軸の負の向きに移動
            transform.Translate(new Vector3(-SpeedX, 0, 0) * Time.deltaTime);
        }

        //Wを押しているとき　かつ　このオブジェクトのY座標がYMaxより小さいとき
        if (Input.GetKey(KeyCode.W) && this.transform.position.y < YMax)
        {
            //Y軸の正の向きに移動
            transform.Translate(new Vector3(0, SpeedY, 0) * Time.deltaTime);
        }
        //Sを押しているとき　かつ　このオブジェクトのY座標がYMinより大きいとき
        if (Input.GetKey(KeyCode.S) && this.transform.position.y > YMin)
        {
            //Y軸の負の向きに移動
            transform.Translate(new Vector3(0, -SpeedY, 0) * Time.deltaTime);
        }

    }

    //オブジェクトに触れたかを検知するコードを追加

    private void OnTriggerEnter(Collider other)//otherにはぶつかったオブジェクトが入れられる
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            Destroy(this.gameObject);
        }
    }
}
