using UnityEngine;

public class DisplayDistanceText : MonoBehaviour
{

    [SerializeField] private TextMeshProGUI _distanceText;
    [SerializeField] private Transform _playerTrans;
    private Vector2 _startPosition;
    private void start()
    {
        _startPosition = _playerTrans.position;
    }

    private void Update()
    {
        Vector2 distance = (Vector2) _playerTrans.position - _startPosition;
        distance.y = 0;
        if(distance.x < 0) distance.x = 0;
        _distanceText.text = distance.x.ToString("0"); 
    }

}
