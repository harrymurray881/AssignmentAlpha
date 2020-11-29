using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerH : MonoBehaviour
{
    public float moveSpeed = 30;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Helicopter Movement
        //up and down
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        //Left and right
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //fire missile
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);

        }
    }
}
