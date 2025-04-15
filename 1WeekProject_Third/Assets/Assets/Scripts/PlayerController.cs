using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public DynamicJoystick joyStick;
    public float speed;

    public float maxHealth;
    private float currentHealth;
    private Vector3 moveVector;

    public GameObject bulletPrefab; 
    public Transform muzzleLocation;

    private Rigidbody rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
    }

    private void Update()
    {
        float x = joyStick.Horizontal;
        
        float z = joyStick.Vertical;

        moveVector = new Vector3(x, 0, z) * speed * Time.fixedDeltaTime;

        rigid.MovePosition(rigid.position + moveVector);

        if(moveVector.sqrMagnitude == 0)
        {
            return;
        }
        //else
        //{
        //    AudioManager.Instance.PlaySFX("DrivingSound");
        //}

        Quaternion directionQuaternion = Quaternion.LookRotation(moveVector);
        Quaternion moveQuaternion = Quaternion.Slerp(rigid.rotation, directionQuaternion, 0.3f);
        rigid.MoveRotation(moveQuaternion);

    }

    public void Shoot()
    {
        Debug.Log("Shoot");

        AudioManager.Instance.PlaySFX("FireSound");
        GameObject bulletGameObject = Instantiate(bulletPrefab, muzzleLocation.position, muzzleLocation.rotation);
        bulletGameObject.GetComponent<Rigidbody>().velocity = (muzzleLocation.transform.right *-1) * 40.0f;
    }
}
