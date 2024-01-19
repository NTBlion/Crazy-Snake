using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotButton : MonoBehaviour
{
    private const string BotText = "BOT";
    private const string PlayerText = "Player";

    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Slot _slot;

    private void Start()
    {
        UpdateText();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        _slot.SwitchInput();
        UpdateText();
    }

    private void UpdateText()
    {
        _text.text = _slot.IsPlayerInput ? PlayerText : BotText;
    }
}