﻿using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StayInTarkov.Coop.Controllers.HandControllers
{
    public sealed class SITFirearmControllerAI : EFT.Player.FirearmController
    {
        ManualLogSource BepInLogger = BepInEx.Logging.Logger.CreateLogSource(nameof(SITFirearmControllerAI));

        public override Vector3 WeaponDirection => _player.LookDirection;
    }
}
