using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    [Header("Objeto")]
    [Tooltip("Objeto a seguir")]
    [SerializeField] private GameObject body;
    [Header("Offset")]
    [Tooltip("Offset en el eje X")]
    [Range(-2f,2f)]
    [SerializeField] private float offsetX = 0;
    [Tooltip("Offset en el eje Y")]
    [Range(-2f,2f)]
    [SerializeField] private float offsetY = 2f;
    [Tooltip("Offset en el eje Z")]
    [Range(-2f,2f)]
    [SerializeField] private float offsetZ = -1f;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(offsetX,offsetY,offsetZ);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = body.transform.position + offset;
    }
}
