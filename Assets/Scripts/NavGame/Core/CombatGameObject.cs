﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavGame.Managers;

namespace NavGame.Core
{
    public class CombatGameObject : DamageableGameObject
    {

        float cooldown = 0f;


        protected virtual void Update()
        {
            DescreaseAttackCooldown();
        }

        public void AttackOnCooldown(DamageableGameObject target)
        {
            if (cooldown <= 0f)
            {
                cooldown = 1f / stats.attackSpeed;
                target.TakeDamage(stats.damage);
                AudioManager.instance.Play("enemy-hit", target.transform.position);
            }
        }

        void DescreaseAttackCooldown()
        {
            if (cooldown == 0f)
            {
                return;
            }
            cooldown -= Time.deltaTime;
            if (cooldown < 0f)
            {
                cooldown = 0f;
            }
        }
    }
}