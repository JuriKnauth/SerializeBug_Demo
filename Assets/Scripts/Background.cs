using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private Image _backgroundImage;
    [SerializeField] private TextMeshProUGUI _backgroundColorText;
    [SerializeField] private Color _backgroundColor;

    private void Awake()
    {
        _backgroundImage.color = _backgroundColor;

        _backgroundColorText.text = _backgroundColor.ToString();
    }
}
