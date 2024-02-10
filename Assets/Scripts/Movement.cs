using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool _isMoving = false;
    private Vector3 _targetPosition;
    [SerializeField] private float _speed;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (_isMoving)
        {
            Move();
        }
    }

    private void SetTargetPosition()
    {
        _targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _targetPosition.z = transform.position.z;

        _isMoving = true;

        _animator.Play("Walk");

    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        if (transform.position == _targetPosition)
        {
            _isMoving = false;
            _animator.Play("Idle");
        }
    }
}
