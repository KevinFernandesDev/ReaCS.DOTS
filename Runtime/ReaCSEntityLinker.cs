using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace ReaCS.Runtime.ECS
{
    public static class ReaCSEntityLinker
    {
        private static readonly Dictionary<ObservableScriptableObject, Entity> soToEntity = new();
        private static readonly Dictionary<Entity, ObservableScriptableObject> entityToSO = new();

        public static void Link(ObservableScriptableObject so, Entity entity)
        {
            soToEntity[so] = entity;
            entityToSO[entity] = so;
        }

        public static Entity GetEntityFor(ObservableScriptableObject so) => soToEntity.TryGetValue(so, out var e) ? e : Entity.Null;
        public static T GetSOFor<T>(Entity entity) where T : ObservableScriptableObject => entityToSO.TryGetValue(entity, out var so) ? so as T : null;
    }
}