#pragma once

#ifndef ADDRESSBOOKCORE_EXPORTS
#pragma comment(lib, "AddressBookCore.lib")
#endif
#define API_CALL  __declspec(dllexport)

/**	address book API exposed to the external modules (.Net)
*/
extern "C"
{
	//some testing/demo code
	API_CALL void __stdcall test();

	//returns size of the binary array representation of the address book
	API_CALL size_t __stdcall addressBookBinarySize();

	//returns binary representation of the AB, owner of the pointer is the caller
	API_CALL void __stdcall getAddressBook(unsigned char *buffer, size_t *size);
}
