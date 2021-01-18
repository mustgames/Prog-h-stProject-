using UnityEngine;

public class PLLogic : MonoBehaviour
{

    public Transform[] moveThing;

    public Transform blaster;
    public GameObject blastPrefap;

    public float moveSpd;

    public float NRJ = 0;
    public float shootingNRJCost = 15.0f;

    public float charge = 0.0f;
    public float chargeSpeed = 1.0f;
    public float maxCharge = 100.0f;
    static bool charged = false;
    public BlastCharge charger;

    void Start()
    {
        charger.SetMaxEnergy(charge);
    }

    void Update()
    {
        Moving();
        Shooting();
    }
    public void Moving()
    {
        if (Input.GetAxis("Hor") != 0) // rör spelaren med unitys input system genom att kolla alla inputs på horizentala axien 
                                       // Movething array följer listan i unity engine Hierarcy
        {
            moveThing[0].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[1].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[2].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[3].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[4].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[5].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[6].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
            moveThing[7].position += new Vector3(Input.GetAxis("Hor") * Time.deltaTime * moveSpd, 0, 0);
        }
    }
   
    public void Shooting()
    {
        if (charge > maxCharge)
        {
            charged = true;
        }
        else
        {
            charged = false;
        }

        if (Input.GetKey(KeyCode.Space) && charged == false)
        {
            charge = charge + chargeSpeed;
            charger.SetEnergyValue(chargeSpeed);
        }
        else if (!Input.GetKey(KeyCode.Space) && charge > 0.0f)
        {
            charge = charge - chargeSpeed;
        
        }

        if (Input.GetKeyUp(KeyCode.Space) && charged == true && NRJ + shootingNRJCost >= 0.0f)
        {
            Instantiate(blastPrefap, blaster.position, blaster.rotation);
        }
        Debug.Log(charge); Debug.Log(charged); Debug.Log(NRJ);
    }

}
