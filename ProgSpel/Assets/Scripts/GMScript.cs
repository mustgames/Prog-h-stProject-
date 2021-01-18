using UnityEngine;

public class GMScript : MonoBehaviour
{
    public Transform playerTrans;
    public float KillZone;


    public GameObject LoseUi;
    public GameObject WinUi;


    void Update()
    {
        if (playerTrans.position.y < KillZone)
        {
            Death();
        }
    }

    public void Death()
    {
        LoseUi.SetActive(true);
        Time.timeScale = 0;
    }

    public void Win()
    {
        WinUi.SetActive(true);
    }
}