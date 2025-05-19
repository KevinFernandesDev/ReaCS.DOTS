using Unity.Entities;

namespace ReaCS.Runtime.ECS
{
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    public partial struct SyncECSToSOSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            foreach (var (selected, entity) in SystemAPI.Query<RefRO<ExperienceSelected>>().WithEntityAccess())
            {
                var so = ReaCSEntityLinker.GetSOFor<ExperienceSO>(entity);
                if (so != null && so.isSelected.Value != selected.ValueRO.Value)
                {
                    so.isSelected.Value = selected.ValueRO.Value;
                }
            }
        }
    }
}