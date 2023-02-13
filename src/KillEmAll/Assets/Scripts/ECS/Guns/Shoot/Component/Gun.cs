﻿using ECS.Guns.Data.Component;
using Unity.Entities;

namespace ECS.Guns.Shoot.Component
{
    public struct Gun : IComponentData
    {
        public int CurrentAmmo;
        
        public GunStatsConfigData GunStatsConfigData;

        public bool IsReloading;
        public bool IsShooting;

        public Entity BulletPrefab;
        public Entity BulletSpawnPoint;
        public Entity EntityView;
    }
}