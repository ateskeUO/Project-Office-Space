using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeWorkers : MonoBehaviour
{
    GameObject player;
    public float radarRange;
    public Light eyeBall_Prefab1;
    public Light eyeBall_Prefab2;
    public GameObject computerScreen;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(computerScreen.transform);
    }

    // Update is called once per frame
    void Update()
    {
        SpookyLook();
    }

    void SpookyLook()
    {
        Vector3 distanceToPlayer = player.transform.position - transform.position;

        if(distanceToPlayer.magnitude < radarRange) {

            transform.LookAt(player.transform);
            eyeBall_Prefab1.intensity = 50;
            eyeBall_Prefab2.intensity = 50;

        }

        if(distanceToPlayer.magnitude >= radarRange)
        {

            transform.LookAt(computerScreen.transform);
            eyeBall_Prefab1.intensity = 0;
            eyeBall_Prefab2.intensity = 0;

        }
    }
}
