using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform Enemy;
    public Transform PlayerTransform;
    public Transform[] MovePoints;

    public float EnemyMoveSpeed;
    public float EnemyWaitDistance;
    void Update()
    {
        
        if(PlayerTransform.position.x < Enemy.position.x + EnemyWaitDistance)
        {
            MoveRight();
    
        }

        else if (PlayerTransform.position.x > Enemy.position.x + EnemyWaitDistance)
        {
            MoveLeft();

        }
        //else if (PlayerTransform.position.x > Enemy.position.x  )
       // {
           // MoveCenter(); 
       // }

    }

    void MoveRight()
    {
        Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, MovePoints[0].transform.position, Time.deltaTime * EnemyMoveSpeed);

    }
    void MoveCenter()
    {
        Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, MovePoints[1].transform.position, Time.deltaTime * EnemyMoveSpeed);

    }
    void MoveLeft()
    {
        Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, MovePoints[2].transform.position, Time.deltaTime * EnemyMoveSpeed);

    }
}
