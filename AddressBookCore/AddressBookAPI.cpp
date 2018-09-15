#include "stdafx.h"
#include "AddressBookAPI.h"
#include "AddressBook.h"

API_CALL void test()
{
	AB->Instance();
	AB->iterateAB();
	AB->addSomeRecords();
	AB->save();
}

API_CALL size_t __stdcall addressBookBinarySize()
{
	return AB->binarySize();
}

API_CALL void __stdcall getAddressBook(unsigned char * bufferOut, size_t *size)
{
	*size = AB->binarySize();
	AB->getAddresBookBinary(bufferOut);
}
