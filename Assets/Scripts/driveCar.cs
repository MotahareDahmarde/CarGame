using UnityEngine;

public class driveCar : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _frontTireRB;
    [SerializeField] private Rigidbody2D _backTireRB;
    [SerializeField] private Rigidbody2D _carRB;
    [SerializeField] private float _speed = 150f;
    [SerializeField] private float _rotationSpeed = 300f;
    [SerializeField] private AudioSource hornSound;
    private float _moveInput;

    void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(keyCode.H))
        {
            hornSound.play();
        }
    }

    private void FixedUpdate()
    {
        _frontTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backTireRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carRB.AddTorque(-_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }
}
