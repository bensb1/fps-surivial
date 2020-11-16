using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public float distance = 10f;
    public Transform equipPosition;
    GameObject currentWeapon;
    bool canGrab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckGrab();
        if(canGrab)
        {
            if(Input.GetKeyDown(KeyCode.E))
            pickUp();
        } 
    }
    private void CheckGrab()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "CanGrab")
            {
                Debug.Log(" I can Grab it!");
                currentWeapon = hit.transform.gameObject;
                canGrab = true;

            }
            
        }
        else canGrab = false;
    }
    private void pickUp()
    {
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0f, 180f, 180f);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log("picked it up");
    }
}
