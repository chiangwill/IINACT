// Copyright © 2023 Ravahn - All Rights Reserved
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY. without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see<http://www.gnu.org/licenses/>.

using System.Collections.Generic;

namespace Machina.FFXIV.Headers
{
    /// <summary>
    /// Enumerates the known FFXIV server message types.  Note that some names were adopted from the Sapphire project
    /// </summary>

    public class Server_MessageType
    {
        public static Server_MessageType StatusEffectList;
        public static Server_MessageType StatusEffectList2;
        public static Server_MessageType StatusEffectList3;
        public static Server_MessageType BossStatusEffectList;
        public static Server_MessageType Ability1;
        public static Server_MessageType Ability8;
        public static Server_MessageType Ability16;
        public static Server_MessageType Ability24;
        public static Server_MessageType Ability32;
        public static Server_MessageType ActorCast;
        public static Server_MessageType EffectResult;
        public static Server_MessageType EffectResultBasic;
        public static Server_MessageType ActorControl;
        public static Server_MessageType ActorControlSelf;
        public static Server_MessageType ActorControlTarget;
        public static Server_MessageType UpdateHpMpTp;
        public static Server_MessageType PlayerSpawn;
        public static Server_MessageType NpcSpawn;
        public static Server_MessageType NpcSpawn2;
        public static Server_MessageType ActorMove;
        public static Server_MessageType ActorSetPos;
        public static Server_MessageType ActorGauge;
        public static Server_MessageType PresetWaymark;
        public static Server_MessageType Waymark;
        public static Server_MessageType SystemLogMessage;
        public static Server_MessageType StatusEffectListForay3;

        internal static void Initialize(Dictionary<string, ushort> opcodes)
        {
            StatusEffectList = Get(opcodes, "StatusEffectList");
            StatusEffectList2 = Get(opcodes, "StatusEffectList2");
            StatusEffectList3 = Get(opcodes, "StatusEffectList3");
            BossStatusEffectList = Get(opcodes, "BossStatusEffectList");
            Ability1 = Get(opcodes, "Ability1");
            Ability8 = Get(opcodes, "Ability8");
            Ability16 = Get(opcodes, "Ability16");
            Ability24 = Get(opcodes, "Ability24");
            Ability32 = Get(opcodes, "Ability32");
            ActorCast = Get(opcodes, "ActorCast");
            EffectResult = Get(opcodes, "EffectResult");
            EffectResultBasic = Get(opcodes, "EffectResultBasic");
            ActorControl = Get(opcodes, "ActorControl");
            ActorControlSelf = Get(opcodes, "ActorControlSelf");
            ActorControlTarget = Get(opcodes, "ActorControlTarget");
            UpdateHpMpTp = Get(opcodes, "UpdateHpMpTp");
            PlayerSpawn = Get(opcodes, "PlayerSpawn");
            NpcSpawn = Get(opcodes, "NpcSpawn");
            NpcSpawn2 = Get(opcodes, "NpcSpawn2");
            ActorMove = Get(opcodes, "ActorMove");
            ActorSetPos = Get(opcodes, "ActorSetPos");
            ActorGauge = Get(opcodes, "ActorGauge");
            PresetWaymark = Get(opcodes, "PresetWaymark");
            Waymark = Get(opcodes, "Waymark");
            SystemLogMessage = Get(opcodes, "SystemLogMessage");
            StatusEffectListForay3 = Get(opcodes, "StatusEffectListForay3");
        }

        private static Server_MessageType Get(Dictionary<string, ushort> opcodes, string key)
        {
            return opcodes.TryGetValue(key, out ushort value) ? value : (ushort)0;
        }

        public ushort InternalValue { get; private set; }

        public override bool Equals(object obj)
        {
            Server_MessageType otherObj = (Server_MessageType)obj;
            return otherObj.InternalValue.Equals(InternalValue);
        }

        public static bool operator ==(Server_MessageType obj1, Server_MessageType obj2)
        {
            return obj1.InternalValue == obj2.InternalValue;
        }
        public static bool operator ==(ushort obj1, Server_MessageType obj2)
        {
            return obj1 == obj2.InternalValue;
        }
        public static bool operator ==(Server_MessageType obj1, ushort obj2)
        {
            return obj1.InternalValue == obj2;
        }

        public override int GetHashCode()
        {
            return InternalValue.GetHashCode();
        }

        public static bool operator !=(Server_MessageType obj1, Server_MessageType ojb2)
        {
            return !(obj1 == ojb2);
        }
        public static bool operator !=(ushort obj1, Server_MessageType ojb2)
        {
            return !(obj1 == ojb2);
        }
        public static bool operator !=(Server_MessageType obj1, ushort ojb2)
        {
            return !(obj1 == ojb2);
        }

        public static implicit operator Server_MessageType(ushort otherType)
        {
            return new Server_MessageType
            {
                InternalValue = otherType
            };
        }

        public static implicit operator ushort(Server_MessageType otherType)
        {
            return otherType.InternalValue;
        }
    }
}
