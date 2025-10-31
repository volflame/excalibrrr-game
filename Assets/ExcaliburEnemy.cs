using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;

public class ExcaliburEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private CinemachineImpulseSource impulseSource;
    void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D()
    {
        CameraShakeManager.instance.CameraShake(impulseSource);
    }
}
