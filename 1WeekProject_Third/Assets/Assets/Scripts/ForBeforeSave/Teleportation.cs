using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    public GameObject subamarine;

    private void Awake()
    {
        CheckForDestructibles();

        Invoke("Destroy", 3.0f);
    }

    private void CheckForDestructibles()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 4.0f);

        foreach(Collider collider in colliders)
        {
            if(collider.GetComponent<PlayerUnit>())
            {
                Debug.Log(collider.gameObject.name);
                collider.transform.position = subamarine.transform.position;
            }
        }
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }

}
