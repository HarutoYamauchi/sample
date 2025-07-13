using UnityEngine;

public class EnemyMoveb : MonoBehaviour
{
    [SerializeField] private float enemySpeed = -5;

    void Update()
    {
        transform.Translate(new Vector3(0, 0, enemySpeed) * Time.deltaTime);//“G‚ª‰º•ûŒü‚É—Ž‚¿‚Ä‚­‚é


    }
}
