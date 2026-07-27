// This is an example of how to hook to a BASE addres
// with offsets to target functions in Dynamic memory Allocation.

#include <windows.h> //use Windows API to use system library

BOOL WINAPI DLLMain(HINSTANCE hinstDLL, DWORD fdwReason,
                    LPVOID lpvReserved)
{
        DWORD old_protect;

        if (fdwReason == DLL_PROCESS_ATTACH){
            //hooking code would be here (your code cave/s)
        }
        return true;
}

/*
Note: the Linker chooses the offsets based on symbol
resolution, section layout, and alignment rules. in PIE builds,
offsets are relatie to segment base, in Non-PIE builds, they're
relative to fixed base chosen by loader.

ASLR randomizes the base address using a pseudo-random 
number generator seeded at process creation. The offst within
segment is fixed for that binary, but base is chosen from a
restricted range to maintain page aligment and compatibililty.
in essence:

Linker: decides the relative offset of each function within its segment.

ASLR: decides the absolute base address of segment which shifts
all offsets in memory.

Together: they ensure that the same function can be at different
absolute addresses each time the program runs, enhancing security.

Part of Dynamic Memory Allocation.

*/