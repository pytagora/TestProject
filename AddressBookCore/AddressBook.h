#pragma once
#include <string>
#include "AddressBook.pb.h"

//macro to access singleton
#define AB (CAddressBook::Instance())

/**
	wrapper class around protobuf implementation
	of the address book
*/
class CAddressBook
{
private:
	CAddressBook();
	~CAddressBook();
public:
	static CAddressBook *Instance();
	void load();
	void save();

	//demonstration, how to add some records
	void addSomeRecords();

	//demonstration, how to iterate address book
	void iterateAB();

	//needed for external allocation of the memory
	size_t binarySize();

	/**	copy binary representation of the address book to
		the pointer *ab.
		caller is responsible for allocation of the memory
	*/
	void getAddresBookBinary(BYTE *ab);
private:
	std::wstring getFilePath() const;
	
	static CAddressBook *m_pInstance;

	Abook::AddressBook *m_pPBAddressBook;
};