using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private Image _backgroundImage;
    [SerializeField] private TextMeshProUGUI _backgroundColorText;
    [SerializeField] private Color _backgroundColorRenamed;

    private void Awake()
    {
        _backgroundImage.color = _backgroundColorRenamed;

        _backgroundColorText.text = _backgroundColorRenamed.ToString();
    }
}
