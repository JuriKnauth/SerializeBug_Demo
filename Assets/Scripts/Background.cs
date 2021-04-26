using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private Image _backgroundImage;
    [FormerlySerializedAs("_backgroundColorText")] [SerializeField] private TextMeshProUGUI _backgroundColorTextRenamed;
    [SerializeField] private Color _backgroundColorRenamed;

    private void Awake()
    {
        _backgroundImage.color = _backgroundColorRenamed;

        _backgroundColorTextRenamed.text = _backgroundColorRenamed.ToString();
    }
}
