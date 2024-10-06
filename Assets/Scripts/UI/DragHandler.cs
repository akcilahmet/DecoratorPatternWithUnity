using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace DecoratorPattern
{
    public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        private const float DRAG_ALPHA = 0.7f;
        private const float DEFAULT_ALPHA = 1f;

        private RectTransform _rectTransform;
        private CanvasGroup _canvasGroup;

        [SerializeField]
        private Canvas _canvas;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            _canvasGroup.alpha = DRAG_ALPHA;
            _canvasGroup.blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (_canvas != null)
            {
                _rectTransform.anchoredPosition += eventData.delta / _canvas.scaleFactor;
            }
            else
            {
                Debug.LogError("Canvas reference is missing!");
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _canvasGroup.alpha = DEFAULT_ALPHA;
            _canvasGroup.blocksRaycasts = true;
        }
    }
}