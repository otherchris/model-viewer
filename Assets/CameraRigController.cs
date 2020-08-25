using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRigController : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera[] cameras;
    void Start()
    {
        cameras = gameObject.GetComponentsInChildren<Camera>();
        Debug.Log(cameras.Length);
        foreach(Camera c in cameras) {
            Debug.Log("hel");
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Camera c in cameras) {
            c.gameObject.transform.rotation = Quaternion.LookRotation(new Vector3(0f, 0f, 0f));
        }
        if(Input.GetKeyDown(KeyCode.Q)) {
            this.AllOff();
            cameras[0].gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.W)) {
            this.AllOff();
            cameras[1].gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.E)) {
            this.AllOff();
            cameras[2].gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.A)) {
            this.AllOff();
            cameras[3].gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.S)) {
            this.AllOff();
            cameras[4].gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.D)) {
            this.AllOff();
            cameras[5].gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.K)) {
            transform.position += Vector3.up * 0.1f;
        }
        if(Input.GetKeyDown(KeyCode.L)) {
            transform.position += Vector3.down * 0.1f;
        }
        
    }

    void AllOff()
    {
        foreach(Camera c in cameras) {
            c.gameObject.SetActive(false);
        }
    }
}
