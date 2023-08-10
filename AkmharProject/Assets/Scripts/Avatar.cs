using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    // Start is called before the first frame update
    private static Vector3 _originalPosition;
    private Vector3 _originalShipRotation;
    private Rigidbody _rigidbody;
    private Transform _shipTransform;
    void Start()
    {
        _originalPosition = transform.position;
        _rigidbody=GetComponent<Rigidbody>();
        _shipTransform=transform.Find("Ship");
        _originalShipRotation = _shipTransform.rotation.eulerAngles;
    }

    

    // Update is called once per frame

    private Vector3 _shipRotation;
    private Vector3 velocity;

    [SerializeField] private Vector3 vector3;
    void Update()
    {
        _shipRotation = _shipTransform.rotation.eulerAngles;
        // velocity = _rigidbody.velocity;


        
        // jumpVelocity = (Camera.main.ScreenToWorldPoint( Input.mousePosition) - transform.position)*_jumpVelocityMultiplier;

            Ray ray =Camera.main.ScreenPointToRay( Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, 10f, 1 << 6);

        // Physics2D.Raycast
        // Debug.Log("Direction "+ Quaternion.Euler(ray.direction).eulerAngles+ "\n Hit: "+(raycastHit.collider != null ? raycastHit.collider.name :"none") +"Point: "+raycastHit.point);

        Debug.DrawLine(ray.origin, raycastHit.point, Color.magenta);

            

            //Convierte la posición del jugador en términos de posición en pantalla.
         Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

        //Apunta el jugador hacia el puntero del ratón.
        Vector3 playerDirection = Input.mousePosition - playerScreenPosition;
        float angle = Mathf.Atan2(playerDirection.x, playerDirection.y) * Mathf.Rad2Deg;

        Debug.Log( Quaternion.AngleAxis(angle, Vector3.up).eulerAngles.y);

        _shipRotation.y = Quaternion.AngleAxis(angle, Vector3.up).eulerAngles.y;

        // _shipTransform.rotation = Quaternion.AngleAxis(angle, Vector3.up) ;
        _shipTransform.rotation = Quaternion.Euler(_shipRotation) ;

        
 
             

        
        // _shipTransform.rotation = Quaternion.Euler(shipRotation);


            // Debug.Log();

        // _shipTransform.TransformDirection(
        //     ray.direction
        // );

        
        
        
        // _shipTransform.LookAt(Camera.main.ScreenToWorldPoint( Input.mousePosition), vector3);

        Physics.BoxCast(_shipTransform.position ,new(_shipTransform.GetComponent<CapsuleCollider>().radius, _shipTransform.GetComponent<CapsuleCollider>().radius, _shipTransform.GetComponent<CapsuleCollider>().height/2), -_shipTransform.up,out RaycastHit boxCastHit);
        // Debug.DrawLine(_shipTransform.positin, Color.yellow);

        // Debug.Log.

        if(boxCastHit.collider!=null){
            if(Input.GetMouseButton(0))
            
            _rigidbody.velocity = _shipTransform.forward * 1f;
        
            else if(Input.GetMouseButton(1))
            
            _rigidbody.velocity = -_shipTransform.forward * 1f;
        }        


        
        
        
                        


        // if(Input.GetKeyDown(KeyCode.R)){
        //     Debug.Log("ok");
        //     transform.position = _originalPosition;
        //     _rigidbody.velocity=new();
        //     shipRotation = _originalShipRotation
        // }
        
        

        // if(Input.GetKey(KeyCode.A)){

        //      shipRotation.y--;
                


        // }else if(Input.GetKey(KeyCode.D)){
            
            
        //     // velocity.x = transform.right.x ;

            
        //     shipRotation.y++;
            

        // }

        // else if(Input.GetKey(KeyCode.W)){
        //     shipRotation.x++;
        // }
        // else if(Input.GetKey(KeyCode.S)){
        //     shipRotation.x--;
        // }else if(Input.GetKey(KeyCode.Space)){
        //     _rigidbody.AddRelativeForce(_shipTransform.forward * (_rigidbody.velocity.magnitude * .33f),ForceMode.Acceleration);
        // }
        

        
        // _rigidbody.velocity=velocity;

    }

    
    

 
}
