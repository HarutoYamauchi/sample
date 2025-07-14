using UnityEngine;

public class EnemyMoveb : MonoBehaviour
{
    [SerializeField] private float enemySpeed = -5;
    [SerializeField] private float enemyLifeTime;//追加
    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemySpeed) * Time.deltaTime);//敵が下方向に落ちてくる

        //以下のコードを追加
        //もしLifeTimeが０より小さくなったら
        if (enemyLifeTime < 0)
        {
            Destroy(this.gameObject);//このオブジェクトを削除
        }
    }
    private void OnTriggerEnter(Collider other)//otherにはぶつかったオブジェクトが入れられる
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}