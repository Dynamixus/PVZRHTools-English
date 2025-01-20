﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVZRHTools
{
    [Serializable]
    public struct ModifierSaveModel
    {
        public bool CardNoInit { get; set; }
        public List<CardUIVM> CardReplaces { get; set; }
        public bool ChomperNoCD { get; set; }
        public bool ClearOnWritingField { get; set; }
        public bool ClearOnWritingZombies { get; set; }
        public bool CobCannonNoCD { get; set; }
        public double Col { get; set; }
        public bool ColumnPlanting { get; set; }
        public bool DeveloperMode { get; set; }
        public bool DevLour { get; set; }
        public bool Exchange { get; set; }
        public bool FastShooting { get; set; }
        public string FieldString { get; set; }
        public bool FreeCD { get; set; }
        public bool FreePlanting { get; set; }
        public double GameSpeed { get; set; }
        public bool GarlicDay { get; set; }
        public double GloveFullCD { get; set; }
        public bool GloveFullCDEnabled { get; set; }
        public bool GloveNoCD { get; set; }
        public double HammerFullCD { get; set; }
        public bool HammerFullCDEnabled { get; set; }
        public bool HammerNoCD { get; set; }
        public bool HardPlant { get; set; }
        public List<HotkeyUIVM> Hotkeys { get; set; }
        public bool HyponoEmperorNoCD { get; set; }
        public int ImpToBeThrown { get; set; }
        public bool IsMindCtrl { get; set; }
        public bool ItemExistForever { get; set; }
        public int ItemType { get; set; }
        public bool JackboxNotExplode { get; set; }
        public int LockBulletType { get; set; }
        public bool LockMoney { get; set; }
        public int LockPresent { get; set; }
        public bool LockSun { get; set; }
        public bool MineNoCD { get; set; }
        public bool NeedSave { get; set; }
        public string NewLevelName { get; set; }
        public double NewMoney { get; set; }
        public double NewSun { get; set; }
        public bool NoFail { get; set; }
        public bool NoHole { get; set; }
        public bool NoIceRoad { get; set; }
        public bool PlantingNoCD { get; set; }
        public int PlantType { get; set; }
        public bool PresentFastOpen { get; set; }
        public double Row { get; set; }
        public bool ScaredyDream { get; set; }
        public bool SeedRain { get; set; }
        public bool Shooting1 { get; set; }
        public bool Shooting2 { get; set; }
        public bool Shooting3 { get; set; }
        public bool Shooting4 { get; set; }
        public string ShowText { get; set; }
        public bool StopSummon { get; set; }
        public bool SuperPresent { get; set; }
        public double Times { get; set; }
        public bool TopMostSprite { get; set; }
        public List<TravelBuffVM> TravelBuffs { get; set; }
        public bool UltimateRamdomZombie { get; set; }
        public bool UndeadBullet { get; set; }
        public bool UnlockAllFusions { get; set; }
        public string ZombieFieldString { get; set; }
        public double ZombieSeaCD { get; set; }
        public bool ZombieSeaEnabled { get; set; }
        public List<int> ZombieSeaTypes { get; set; }
        public int ZombieType { get; set; }
    }
}