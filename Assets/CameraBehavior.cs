using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    private Transform target;

    public Transform targetOrigin;
    public Transform targetExchange;
    public Vector3 offset;
    public float rotateSpeed = 5.0f;
    public float moveSpeed = 5.0f;
    private float pitch = 0.0f;
    public bool defaultTarget = true;


    private float yaw = 0.0f;

    void Start(){
        target = targetOrigin;
        transform.position = target.position + offset;
    }

    void Update()
    {
        scroll();
    }

    void LateUpdate()
    {
        rotate();
    }

    void scroll()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        float scale = 1.0f + scroll * 0.3f;
        offset = offset * scale;
       
    }

    void rotate(){
        if (Input.GetMouseButton(1))
        {
            yaw += rotateSpeed * Input.GetAxis("Mouse X");
            pitch += rotateSpeed * Input.GetAxis("Mouse Y");
        }
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0.0f);
        transform.position = target.position - (rotation * offset);
        transform.LookAt(target.position);
    }

    public void changeTarget(){
        if(defaultTarget){
            target = targetExchange;
        } else{
            target = targetOrigin;
}
        defaultTarget = !defaultTarget;
    }
}