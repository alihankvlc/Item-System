using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace _Project.Common.ItemSystem
{
    public class DisplayItem : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _itemNameTextMesh;

        // [SerializeField] private TextMeshProUGUI _itemDescriptionTextMesh;
        [SerializeField] private TextMeshProUGUI _itemCountTextMesh;
        [SerializeField] private Image _itemIcon;

        private Item _item;
        private bool _hasItem;

        private void Start()
        {
            _item = GetComponent<Item>();
            _hasItem = TryGetComponent(out _item);

            if (_hasItem)
            {
                _itemNameTextMesh.SetText(_item.Data.Name);
                //  _itemDescriptionTextMesh.SetText(_item.Data.Description);
                _itemIcon.sprite = _item.Data.Icon;

                _item.ItemCountChanged += (int count) => _itemCountTextMesh.SetText(count.ToString());
            }
        }

        private void OnDestroy()
        {
            _item.ItemCountChanged -= (int count) => _itemCountTextMesh.SetText(count.ToString());
        }
    }
}