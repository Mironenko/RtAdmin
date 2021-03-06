﻿using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using System.Collections.Generic;
using System.Linq;

namespace Aktiv.RtAdmin
{
    public class TokenSlot
    {
        private readonly Pkcs11 _pkcs11;

        public TokenSlot(Pkcs11 pkcs11)
        {
            _pkcs11 = pkcs11;
        }

        public Stack<Slot> GetInitialSlots() => new Stack<Slot>(_pkcs11.GetSlotList(SlotsType.WithTokenPresent));

        public Slot WaitToken()
        {
            Slot slot;
            do
            {
                _pkcs11.WaitForSlotEvent(WaitType.Blocking, out _, out var slotId);
                slot = _pkcs11.GetSlotList(SlotsType.WithTokenPresent)
                              .SingleOrDefault(x => x.SlotId == slotId);
            }
            while (slot == null);

            return slot;
        }
    }
}
