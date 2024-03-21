using UnityEngine;

namespace _Project.Common.ItemSystem
{
    public interface ICollectible
    {
        void Collect();
        void Use();
        void Discard();
    }
}