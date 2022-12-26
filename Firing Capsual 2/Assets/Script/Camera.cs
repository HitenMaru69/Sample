using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Transform camera;

    public float smooth = 0.125f;
    public Vector3 offset;


   
    private void LateUpdate()
    {
        Vector3 dic = target.position + offset;
        Vector3 smoothe = Vector3.Lerp(camera.position, dic, smooth);
        camera.position = smoothe;
    }




}
