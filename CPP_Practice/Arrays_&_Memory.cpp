// DLL and Memory Management practice

// Example of an DLL that iterates over an array of byte values, using Windows API

unsigned char new_bytes[8] = {0x90, 0x90, 0x90, 0x83, 0x0E, 0xFF,0x90, 0x90};

unsigned char * hook_location = (unsigned char*)0x6CD519;

if (fdwReason == DLL_PROCESS_ATTACH) {

    VirtualProtet((void*)hook_location, 8 , PAGE_EXECUTE_READWRITE,
    &old_protect;)
        for (int i= 0; i < sizeof(new_bytes); i++) {
        *(hook_location + i ) = new_bytes[i];
        }
}

// this is how a DLL can be injected in the address space, targetting a specific address.

// this can be used as a patch to repair, or temporary redirectoion,
// nullificaiton of an affect (such as keeping something unlocked/visible)
// and many other uses.
// This is of course, understanding Memory Virtualization. So, this would be for a running process.

// A permanent patch would mean updating source code or binaries.