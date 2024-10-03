using System;
using System.Collections.Generic;

namespace RoomsBookings
{
    public class BooksRooms
    {
        public static List<string> Solution(int nAdults, int nChildren)
        {
            int nRooms = 4;
            int nMaxGuests = 4;
            int nPeoples = 16;

            int nTot = nAdults + nChildren;

            var Allocations = new List <string> ();

            if (nTot > nPeoples)
            {
                Allocations.Add("Guest Limited..!!"); 
                return Allocations;
            }

            int nRoomAllocate = 0;

            while ((nAdults > 0 || nChildren > 0) && nRoomAllocate < nRooms)
            {
                int nAdultsRoom = Math.Min(nAdults, 2);
                int nChildrenRoom = Math.Min(nChildren, nMaxGuests - nAdultsRoom);

                Allocations.Add($"Room {nRoomAllocate + 1}: Adult = {nAdultsRoom}, Children = {nChildrenRoom}");
                nAdults = nAdults - nAdultsRoom;
                nChildren = nChildren - nChildrenRoom;
                nRoomAllocate++;
            }

            return Allocations;

        }
    }
}


