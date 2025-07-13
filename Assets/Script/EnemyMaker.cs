using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float makeTime;//何秒後に次のEnemyを生成するかを示す秒数
    private float waitTime;//Enemyを生成してから何秒経ったかを示す時間
    [SerializeField] private float enemyZ;//Enemyを生成するZ座標
    [SerializeField] private float enemyX;//Enemyを生成するX座標
    private float ranX;//ランダムなX座標を示す

    void Start()
    {

    }

    void Update()
    {
        //敵が画面に現れるまでの時間を数える
        if (waitTime < makeTime)
        {
            waitTime = waitTime + Time.deltaTime;
            //waitTimeにフレーム間の時間を足し続けることでタイマーの役割を果たす
        }
        //waitTimeがmakeTimeより大きくなったら
        else
        {
            ranX = Random.Range(enemyX * -1, enemyX);
            //ranXには-enemyからenemyXまでのランダムな数字が入れ字

            Instantiate(enemyPrefab, new Vector3(ranX, 0, enemyZ), enemyPrefab.transform.rotation);
            //オブジェクトを出現させる（enemyPrefabを、(ranX, 0, enemyZ)の座標に、enemyPrefabのrotationの角度で）

            waitTime = 0;//waitTimeを０にすることで、もう一度敵を出現させるまでの時間を数える
        }
    }
}
