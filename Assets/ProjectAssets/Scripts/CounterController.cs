using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public Button addButton;
    public Button substractButton;
    public Button resetButton;
    private int _value = 0;



    private void Start()
    {
        ResetCounter();
        addButton.onClick.AddListener(AddValue);
        substractButton.onClick.AddListener(SubstractValue);
        resetButton.onClick.AddListener(ResetCounter);
    }

    private void AddValue()
    {
        _value++;
        SetTextValue();
    }
    private void SubstractValue()
    {
        _value--;
        SetTextValue();
    }

    private void ResetCounter()
    {
        _value = 0;
        SetTextValue();
    }

    private void SetTextValue()
    {
        counterText.text = _value.ToString();
    }

}
