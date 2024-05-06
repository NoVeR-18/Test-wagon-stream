using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _inputField;
    [SerializeField]
    private TMP_Text _text;
    [SerializeField]
    private Button _button;

    void Start()
    {
        _button.onClick.AddListener(ChangeText);
    }

    private void ChangeText()
    {
        _text.text = _inputField.text;
    }

    void OnDestroy()
    {
        _button?.onClick.RemoveListener(ChangeText);
    }
}
