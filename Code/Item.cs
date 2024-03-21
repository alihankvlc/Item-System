using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Project.Common.ItemSystem
{
    public class Item : MonoBehaviour, ICollectible
    {
        [SerializeField, InlineEditor] private ItemData _itemData;
        [SerializeField] private int _itemCount = 1;


        public event Action<int> ItemCountChanged;

        public ItemData Data => _itemData;

        public int Count
        {
            get => _itemCount;
            private set
            {
                _itemCount = value;
                ItemCountChanged?.Invoke(value);
            }
        }

        private void Start() => ItemCountChanged?.Invoke(_itemCount);

        public void Collect()
        {
            if (_itemData.Stackable) Count++;

            //Add to inventory...
        }

        public void Use()
        {
            //Use..
        }

        public void Discard()
        {
            //Discard...
        }
    }
}