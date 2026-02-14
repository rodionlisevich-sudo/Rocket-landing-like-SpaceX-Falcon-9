using UnityEngine;
using UnityEngine.InputSystem;


class EngineThrust : MonoBehaviour
{
    Rigidbody rb;
    public Transform engine;
    public GameObject Flame;
    public float thrust = 18f;
    public Transform platform;
    public float LandingTime;
    bool isLanding = false;
    [Header("Gimbal Settings")]
    public float maxGimbalAngle = 5f;
    public float gimbalSpeed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0, -2f, 0);
    }
    void FixedUpdate()
    {
        if (transform.position.y < 13) 
        {
        isLanding = true;
        }
        if (transform.position.y < 40)
        {
            maxGimbalAngle = 0.7f;
        }
        float distanceX = transform.position.x - platform.position.x;
        float velocityX = rb.linearVelocity.x;
        float targetGimbalZ = -((distanceX) + (velocityX * 300f));
        targetGimbalZ = Mathf.Clamp(targetGimbalZ, -maxGimbalAngle, maxGimbalAngle);
        float distanceZ = transform.position.z - platform.position.z;
        float velocityZ = rb.linearVelocity.z;
        float targetGimbalX = (distanceZ) + (velocityZ * 300f); 
        targetGimbalX = Mathf.Clamp(targetGimbalX, -maxGimbalAngle, maxGimbalAngle);
        if (transform.position.y < 42)
        {
            targetGimbalZ = -targetGimbalZ;
            targetGimbalX = -targetGimbalX;
        }
        Quaternion targetRotationCombined = Quaternion.Euler(targetGimbalX, 0, targetGimbalZ);
        engine.localRotation = Quaternion.Lerp(engine.localRotation, targetRotationCombined, Time.fixedDeltaTime * gimbalSpeed);
        float velocityY = rb.linearVelocity.y;
        float height = transform.position.y - platform.position.y;
        float landingTime = (velocityY < -0.1f) ? Mathf.Abs(height / velocityY) : 100f;
        bool autoThrust = false;
        if (landingTime < 5f && isLanding == false)
        {
            autoThrust = true;
        }
        if (autoThrust)
        {
            ApplyThrust();
        }
        else
        {
            Flame.SetActive(false);
        }
    }
    void ApplyThrust()
    {
        rb.AddForceAtPosition(engine.up * thrust, engine.position);
        Flame.SetActive(true);
    }
}