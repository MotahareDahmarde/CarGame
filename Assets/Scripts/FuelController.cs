using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public static FuelController instance;
    [SerializeField] private Image _fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float _fuelDrainSpeed = 1f;
    [SerializeField] private float _maxFuelAmount = 100f;
    [SerializeField] private Gradient _fuelGradient;
    private float _currentFuelAmount;

    private void awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void start()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUi();
    }

    private void Update()
    {
        _currentFuelAmount -= Time.deltaTime * _fuelDrainSpeed;
        if (_currentFuelAmount <= 0f)
        {
            GameManager.instance.GameOver();
        }
        UpdateUi();
    }

    private void UpdateUi()
    {
        _fuelImage.fillAmount = (_currentFuelAmount / _maxFuelAmount);
        _fuelImage.color = _fuelGradient.Evaluate(_fuelImage.fillAmount);
    }

    public void FillFuel()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUi();
    }

    public void AddFuelPercentage(float percentage)
    {
        _currentFuelAmount += _maxFuelAmount * (percentage / 100f);
        if (_currentFuelAmount > _maxFuelAmount)
        {
            _currentFuelAmount = _maxFuelAmount;
        }
        UpdateUi();
    }
}
